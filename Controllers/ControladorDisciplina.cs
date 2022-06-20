using System;
using System.Linq;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Entities.JoinClasses;
using SistemaEscola.Entities;
using SistemaEscola.Data;

namespace SistemaEscola.Controllers
{
    class ControladorDisciplina : IController<Disciplina>
    {
        readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

        public static readonly ControladorDisciplina Instance = new ControladorDisciplina();

        public void Add(FormularioDisciplina form)
        {
            // Checks if Disciplina already exists
            if (FindAll().Any(d => d.Nome == form.Nome))
            {
                throw new Exception("Disciplina já cadastrada.");
            }

            // Adds new Disciplina do Db
            InsertIntoDb(form);

            // Updates Avaliacoes
            UpdateDisciplinaAvaliacoes(form, true);
        }

        public void InsertIntoDb(FormularioDisciplina form)
        {
            var disciplina = new Disciplina(form.Nome);

            _context.Disciplinas.Add(disciplina);
            _context.SaveChanges();
        }

        public List<Disciplina> FindAll()
        {
            return _context.Disciplinas.OrderBy(d => d.Nome).ToList();
        }

        public Disciplina FindById(int id)
        {
            var disciplina = _context.Disciplinas.Find(id);

            if (disciplina == null)
            {
                return null;
            }

            return disciplina;
        }

        public Disciplina FindByName(string name)
        {
            var disciplina = _context.Disciplinas.Where(d => d.Nome == name);

            if (!disciplina.Any())
            {
                return null;
            }

            return disciplina.First();
        }

        public void Update(FormularioDisciplina form)
        {
            Disciplina disciplina = FindById(form.Id);

            if (disciplina != null)
            {
                // Updates Disciplina
                disciplina.Nome = form.Nome;

                // Updates professores
                UpdateProfessorDisciplinas(form);

                // Updates turmas
                UpdateTurmaDisciplinas(form);

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Disciplina disciplina = FindById(id);

            if (disciplina != null) 
            {
                _context.Disciplinas.Remove(disciplina);
            }

            _context.SaveChanges();
        }

        // ProfessorDisciplina
        public void AddProfessorDisciplina(int professorId, int disciplinaId)
        {
            if (!_context.ProfessorDisciplinas.Any(pd => pd.ProfessorId == professorId &&
            pd.DisciplinaId == disciplinaId))
            {
                _context.ProfessorDisciplinas.Add(new ProfessorDisciplina()
                {
                    ProfessorId = professorId,
                    DisciplinaId = disciplinaId,
                });
            }
        }

        public void RemoveProfessorDisciplina(int professorId, int disciplinaId)
        {
            var pd = _context.ProfessorDisciplinas.Find(professorId, disciplinaId);

            if (pd != null)
            {
                _context.ProfessorDisciplinas.Remove(pd);
            }
        }

        public void UpdateProfessorDisciplinas(FormularioDisciplina form, bool saveChanges = false)
        {
            var disciplinaId = form.Id;

            if (disciplinaId == 0)
            {
                disciplinaId = FindByName(form.Nome).Id;
            }

            var professorDisciplinas = FindAllProfessorDisciplinasByDisciplina(disciplinaId);

            foreach (var fp in form.FormularioProfessores)
            {
                if (!professorDisciplinas.Any(pd => pd.ProfessorId == fp.Id))
                {
                    AddProfessorDisciplina(fp.Id, disciplinaId);
                }
            }

            foreach (var pd in professorDisciplinas)
            {
                if (!form.FormularioProfessores.Any(fp => fp.Id == pd.ProfessorId))
                {
                    RemoveProfessorDisciplina(pd.ProfessorId, pd.DisciplinaId);
                }
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<ProfessorDisciplina> FindAllProfessorDisciplinasByDisciplina(int disciplinaId)
        {
            return _context.ProfessorDisciplinas.Where(pd => pd.DisciplinaId == disciplinaId).ToList();
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

        public void UpdateTurmaDisciplinas(FormularioDisciplina form, bool saveChanges = false)
        {
            var disciplinaId = form.Id;

            if (disciplinaId == 0)
            {
                disciplinaId = FindByName(form.Nome).Id;
            }

            var turmaDisciplinas = FindAllTurmaDisciplinasByDisciplina(disciplinaId);

            foreach (var ft in form.FormularioTurmas)
            {
                if (!turmaDisciplinas.Any(td => td.TurmaId == ft.Id))
                {
                    AddTurmaDisciplina(ft.Id, disciplinaId);
                }
            }

            foreach (var td in turmaDisciplinas)
            {
                if (!form.FormularioTurmas.Any(ft => ft.Id == td.TurmaId))
                {
                    RemoveTurmaDisciplina(td.TurmaId, td.DisciplinaId);
                }
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<TurmaDisciplina> FindAllTurmaDisciplinasByDisciplina(int disciplinaId)
        {
            return _context.TurmaDisciplinas.Where(td => td.DisciplinaId == disciplinaId).ToList();
        }

        // AlunoFaltaDisciplina
        public void AddAlunoFaltaDisciplina(int alunoId, int disciplinaId)
        {
            if (!_context.AlunoFaltaDisciplinas.Any(afd => afd.AlunoId == alunoId &&
            afd.DisciplinaId == disciplinaId))
            {
                _context.AlunoFaltaDisciplinas.Add(new AlunoFaltaDisciplina()
                {
                    AlunoId = alunoId,
                    DisciplinaId = disciplinaId
                });
            }
        }

        public void RemoveAlunoFaltaDisciplina(int alunoId, int disciplinaId)
        {
            var afd = _context.AlunoFaltaDisciplinas.Find(alunoId, disciplinaId);

            if (afd != null)
            {
                _context.AlunoFaltaDisciplinas.Remove(afd);
            }
        }

        // Not Working
        public void UpdateAlunoFaltaDisciplinas(FormularioDisciplina form, bool saveChanges = false)
        {
            /*
            var disciplinaId = form.Id;

            if (disciplinaId == 0)
            {
                disciplinaId = FindByName(form.Nome).Id;
            }

            var alunoFaltaDisciplinas = FindAllAlunoFaltaDisciplinasByDisciplina(disciplinaId);

            foreach (var ft in form.FormularioAlunoFaltaDisciplinas)
            {
                if (!alunoFaltaDisciplinas.Any(afd => afd.AlunoId == ft.Id))
                {
                    AddAlunoFaltaDisciplina(ft.Id, disciplinaId);
                }
            }

            foreach (var td in turmaDisciplinas)
            {
                if (!form.FormularioTurmas.Any(ft => ft.Id == td.TurmaId))
                {
                    RemoveTurmaDisciplina(td.TurmaId, td.DisciplinaId);
                }
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }*/
        }

        public List<AlunoFaltaDisciplina> FindAllAlunoFaltaDisciplinasByDisciplina(int disciplinaId)
        {
            return _context.AlunoFaltaDisciplinas.Where(afd => afd.DisciplinaId == disciplinaId).ToList();
        }

        //DisciplinaAvaliacao
        public void AddDisciplinaAvaliacao(int disciplinaId, int avaliacaoId)
        {
            if (!_context.DisciplinaAvaliacoes.Any(da => da.DisciplinaId == disciplinaId &&
                da.AvaliacaoId == avaliacaoId))
            {
                _context.DisciplinaAvaliacoes.Add(new DisciplinaAvaliacao()
                {
                    DisciplinaId = disciplinaId,
                    AvaliacaoId = avaliacaoId
                });
            }
        }

        public void UpdateDisciplinaAvaliacoes(FormularioDisciplina form, bool saveChanges = false)
        {
            var disciplinaId = form.Id;

            if (disciplinaId == 0)
            {
                disciplinaId = FindByName(form.Nome).Id;
            }

            AddDisciplinaAvaliacao(disciplinaId, 1);
            AddDisciplinaAvaliacao(disciplinaId, 2);

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<DisciplinaAvaliacao> FindAllDisciplinaAvaliacoesByDisciplina(int disciplinaId)
        {
            return _context.DisciplinaAvaliacoes.Where(da => da.DisciplinaId == disciplinaId).ToList();
        }
    }
}
