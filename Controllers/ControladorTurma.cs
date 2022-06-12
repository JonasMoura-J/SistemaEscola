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
                throw new Exception("Turma já cadastrada");
            }

            // Adds new Turma to Db
            InsertIntoDb(form);

            // Updates Disciplinas
            UpdateTurmaDisciplinas(form, true);

            // Updates Alunos
            UpdateAlunos(form, true);
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

        public void Delete(int Id)
        {
            Turma turma = FindById(Id);

            if (turma != null) {
                _context.Turmas.Remove(turma);
            }

            _context.SaveChanges();
        }

        // Not working for now
        public void Update(FormularioTurma form)
        {
            Turma turma = FindById(form.Id);

            if (turma != null) {

                _context.Turmas.Remove(turma);
                //_context.Turmas.Add(new Turma(form.Id, form.Codigo, form.Nome, form.QuantidadeAlunos, ));
            }
        }

        public List<TurmaDisciplina> FindAllTurmaDisciplinasByDisciplina(int disciplinaId)
        {
            return _context.TurmaDisciplinas.Where(td => td.DisciplinaId == disciplinaId).ToList();
        }

        public void UpdateAlunos(FormularioTurma form, bool saveChanges = false)
        {
            var turmaId = form.Id;

            if (turmaId == 0)
            {
                turmaId = FindByName(form.Nome).Id;
            }

            foreach (var fa in form.FormularioAlunos)
            {
                fa.FormularioDisciplinas = form.FormularioDisciplinas;

                controladorAluno.UpdateTurma(fa.Id, turmaId);
                controladorAluno.UpdateFaltaDisciplinas(fa);
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }
        
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
    }
}
