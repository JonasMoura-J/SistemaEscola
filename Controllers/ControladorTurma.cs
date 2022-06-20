using System;
using System.Linq;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Entities.JoinClasses;
using SistemaEscola.Entities;
using SistemaEscola.Data;

namespace SistemaEscola.Controllers
{
    class ControladorTurma : IController<Turma>
    {
        readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

        readonly ControladorAluno controladorAluno = ControladorAluno.Instance;

        public static readonly ControladorTurma Instance = new ControladorTurma();

        public void Add(FormularioTurma form)
        {
            // Check if already exists
            if (FindAll().Any(d => d.Nome == form.Nome || d.Codigo == form.Codigo))
            {
                throw new Exception("Turma já cadastrada.");
            }

            // Adds new Turma to Db
            InsertIntoDb(form);

            // Updates Disciplinas
            UpdateTurmaDisciplinas(form, true);

            // Updates Avaliacoes
            UpdateTurmaAvaliacoes(form, true);

            // Updates Alunos
            UpdateAlunoTurmas(form, true);
        }
        
        public void InsertIntoDb(FormularioTurma form)
        {
            var turma = new Turma(form.Codigo, form.Nome,
                form.QuantidadeAlunos);

            _context.Turmas.Add(turma);
            _context.SaveChanges();
        }

        public List<Turma> FindAll()
        {
            return _context.Turmas.OrderBy(t => t.Nome).ToList();
        }

        public Turma FindById(int id)
        {
            var turma = _context.Turmas.Find(id);

            if (turma == null)
            {
                return null;
            }

            return turma;
        }

        public Turma FindByName(string name)
        {
            var turma = _context.Turmas.Where(t => t.Nome == name);

            if (!turma.Any())
            {
                return null;
            }

            return turma.First();
        }

        public void Update(FormularioTurma form)
        {
            Turma turma = FindById(form.Id);

            if (turma != null)
            {
                // Updates Turma
                turma.Nome = form.Nome;
                turma.Codigo = form.Codigo;
                turma.QuantidadeAlunos = form.QuantidadeAlunos;

                // Updates disciplinas
                UpdateTurmaDisciplinas(form);

                // Updates professores
                UpdateTurmaProfessores(form);

                // Updates alunos
                UpdateAlunoTurmas(form);
                UpdateAlunoFaltaDisciplina(form);
                
                _context.SaveChanges();
            }
        }

        public void Delete(int Id)
        {
            Turma turma = FindById(Id);

            if (turma != null) {
                _context.Turmas.Remove(turma);
            }

            _context.SaveChanges();
        }
        
        // AlunoTurma
        public void AddAlunoTurma(int alunoId, int turmaId)
        {
            // Only one Turma per Aluno
            if (!_context.AlunoTurmas.Any(at => at.AlunoId == alunoId &&
                at.TurmaId == turmaId))
            {
                var previousTurma = _context.AlunoTurmas.Where(at => at.AlunoId == alunoId).FirstOrDefault();

                if (previousTurma != null)
                {
                    _context.AlunoTurmas.Remove(previousTurma);
                }

                _context.AlunoTurmas.Add(new AlunoTurma()
                {
                    AlunoId = alunoId,
                    TurmaId = turmaId
                });
            }
        }

        public void RemoveAlunoTurma(int alunoId, int turmaId)
        {
            var at = _context.AlunoTurmas.Find(alunoId, turmaId);

            if (at != null)
            {
                _context.AlunoTurmas.Remove(at);
            }
        }
        
        public void UpdateAlunoTurmas(FormularioTurma form, bool saveChanges = false)
        {
            var turmaId = form.Id;

            if (turmaId == 0)
            {
                turmaId = FindByName(form.Nome).Id;
            }

            var alunoTurmas = FindAllAlunoTurmasByTurma(turmaId);

            foreach (var fa in form.FormularioAlunos)
            {
                if (!alunoTurmas.Any(at => at.AlunoId == fa.Id))
                {
                    AddAlunoTurma(fa.Id, turmaId);
                }
            }

            foreach (var at in alunoTurmas)
            {
                if (!form.FormularioAlunos.Any(fa => fa.Id == at.AlunoId))
                {
                    RemoveAlunoTurma(at.AlunoId, at.TurmaId);
                }
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<AlunoTurma> FindAllAlunoTurmasByTurma(int turmaId)
        {
            return _context.AlunoTurmas.Where(at => at.TurmaId == turmaId).ToList();
        }

        // TurmaDisciplina
        public void AddTurmaDisciplina(int turmaId, int disciplinaId)
        {
            if (!_context.TurmaDisciplinas.Any(td => td.TurmaId == turmaId &&
            td.DisciplinaId == disciplinaId))
            {
                _context.TurmaDisciplinas.Add(new TurmaDisciplina()
                {
                    TurmaId = turmaId,
                    DisciplinaId = disciplinaId,
                });
            }
        }

        public void RemoveTurmaDisciplina(int turmaId, int disciplinaId)
        {
            var td = _context.TurmaDisciplinas.Find(turmaId, disciplinaId);

            if (td != null)
            {
                _context.TurmaDisciplinas.Remove(td);
            }
        }

        public void UpdateTurmaDisciplinas(FormularioTurma form, bool saveChanges = false)
        {
            var turmaId = form.Id;

            if (turmaId == 0)
            {
                turmaId = FindByName(form.Nome).Id;
            }

            var turmaDisciplinas = FindAllTurmaDisciplinasByTurma(turmaId);

            foreach (var fd in form.FormularioDisciplinas)
            {
                if (!turmaDisciplinas.Any(td => td.DisciplinaId == fd.Id))
                {
                    AddTurmaDisciplina(turmaId, fd.Id);
                }
            }

            foreach (var td in turmaDisciplinas)
            {
                if (!form.FormularioDisciplinas.Any(fd => fd.Id == td.DisciplinaId))
                {
                    RemoveTurmaDisciplina(td.TurmaId, td.DisciplinaId);
                }
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<TurmaDisciplina> FindAllTurmaDisciplinasByTurma(int turmaId)
        {
            return _context.TurmaDisciplinas.Where(td => td.TurmaId == turmaId).ToList();
        }

        // TurmaProfessor
        public void AddTurmaProfessor(int turmaId, int professorId)
        {
            if (!_context.TurmaProfessores.Any(tp => tp.TurmaId == turmaId &&
            tp.ProfessorId == professorId))
            {
                _context.TurmaProfessores.Add(new TurmaProfessor()
                {
                    TurmaId = turmaId,
                    ProfessorId = professorId,
                });
            }
        }

        public void RemoveTurmaProfessor(int turmaId, int professorId)
        {
            var tp = _context.TurmaProfessores.Find(turmaId, professorId);

            if (tp != null)
            {
                _context.TurmaProfessores.Remove(tp);
            }
        }

        public void UpdateTurmaProfessores(FormularioTurma form, bool saveChanges = false)
        {
            var turmaId = form.Id;

            if (turmaId == 0)
            {
                turmaId = FindByName(form.Nome).Id;
            }

            var turmaProfessores = FindAllTurmaProfessoresByTurma(turmaId);

            foreach (var fp in form.FormularioProfessores)
            {
                if (!turmaProfessores.Any(tp => tp.ProfessorId == fp.Id))
                {
                    AddTurmaProfessor(turmaId, fp.Id);
                }
            }

            foreach (var tp in turmaProfessores)
            {
                if (!form.FormularioProfessores.Any(fp => fp.Id == tp.ProfessorId))
                {
                    RemoveTurmaProfessor(tp.TurmaId, tp.ProfessorId);
                }
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<TurmaProfessor> FindAllTurmaProfessoresByTurma(int turmaId)
        {
            return _context.TurmaProfessores.Where(tp => tp.TurmaId == turmaId).ToList();
        }

        // AlunoFaltaDisciplina
        public void UpdateAlunoFaltaDisciplina(FormularioTurma form, bool saveChanges = false)
        {
            // Works... for some reason... (but there is a logical error going on)

            var turmaId = form.Id;

            if (turmaId == 0)
            {
                turmaId = FindByName(form.Nome).Id;
            }

            var alunoTurmas = FindAllAlunoTurmasByTurma(turmaId);

            foreach (var at in alunoTurmas)
            {
                var tempAluno = new FormularioAluno()
                {
                    Id = at.AlunoId,
                    FormularioDisciplinas = form.FormularioDisciplinas
                };

                controladorAluno.UpdateAlunoFaltaDisciplinas(tempAluno, true);
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        //TurmaAvaliacao
        public void AddTurmaAvaliacao(int turmaId, int avaliacaoId)
        {
            if (!_context.TurmaAvaliacoes.Any(ta => ta.TurmaId == turmaId &&
                ta.AvaliacaoId == avaliacaoId))
            {
                _context.TurmaAvaliacoes.Add(new TurmaAvaliacao()
                {
                    TurmaId = turmaId,
                    AvaliacaoId = avaliacaoId
                });
            }
        }

        public void UpdateTurmaAvaliacoes(FormularioTurma form, bool saveChanges = false)
        {
            var turmaId = form.Id;

            if (turmaId == 0)
            {
                turmaId = FindByName(form.Nome).Id;
            }

            AddTurmaAvaliacao(turmaId, 1);
            AddTurmaAvaliacao(turmaId, 2);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<TurmaAvaliacao> FindAllTurmaAvaliacoesByTurma(int turmaId)
        {
            return _context.TurmaAvaliacoes.Where(ta => ta.TurmaId == turmaId).ToList();
        }
    }
}
