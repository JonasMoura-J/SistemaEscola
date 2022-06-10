using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Data;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Entities.JoinClasses;

namespace SistemaEscola.Controllers
{
    class ControladorDisciplina : IController<Disciplina>
    {
        private readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

        public static readonly ControladorDisciplina Instance = new ControladorDisciplina();

        public void Add(FormularioDisciplina form)
        {
            // Checks if Disciplina already exists
            if (FindAll().Any(d => d.Nome == form.Nome))
            {
                throw new Exception("Disciplina já cadastrada");
            }

            // Adds new Disciplina do Db
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
                var professorDisciplinas = FindAllProfessorDisciplinaByDisciplina(disciplina.Id);

                foreach (var fp in form.FormularioProfessores)
                {
                    if (!professorDisciplinas.Any(pd => pd.ProfessorId == fp.Id))
                    {
                        AddProfessorDisciplina(fp.Id, disciplina.Id, true);
                    }
                }

                foreach (var pd in professorDisciplinas)
                {
                    if (!form.FormularioProfessores.Any(fp => fp.Id == pd.ProfessorId))
                    {
                        RemoveProfessorDisciplina(pd.ProfessorId, pd.DisciplinaId, true);
                    }
                }

                // Updates turmas
                var turmaDisciplinas = FindAllTurmaDisciplinaByDisciplina(disciplina.Id);

                foreach (var ft in form.FormularioTurmas)
                {
                    if (!turmaDisciplinas.Any(td => td.TurmaId == ft.Id))
                    {
                        AddTurmaDisciplina(ft.Id, disciplina.Id, true);
                    }
                }

                foreach (var td in turmaDisciplinas)
                {
                    if (!form.FormularioTurmas.Any(ft => ft.Id == td.TurmaId))
                    {
                        RemoveTurmaDisciplina(td.TurmaId, td.DisciplinaId, true);
                    }
                }

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

        public void AddProfessorDisciplina(int professorId, int disciplinaId, bool isBugged = false)
        {
            if (!_context.ProfessorDisciplinas.Any(pd => pd.ProfessorId == professorId &&
            pd.DisciplinaId == disciplinaId))
            {
                _context.ProfessorDisciplinas.Add(new ProfessorDisciplina()
                {
                    ProfessorId = professorId,
                    DisciplinaId = disciplinaId,
                });

                if (!isBugged)
                {
                    _context.SaveChanges();
                }
            }
        }

        public void RemoveProfessorDisciplina(int professorId, int disciplinaId, bool isBugged = false)
        {
            var pd = _context.ProfessorDisciplinas.Find(professorId, disciplinaId);

            if (pd != null)
            {
                _context.ProfessorDisciplinas.Remove(pd);

                if (!isBugged)
                {
                    _context.SaveChanges();
                }
            }
        }

        public List<ProfessorDisciplina> FindAllProfessorDisciplinaByDisciplina(int disciplinaId)
        {
            return _context.ProfessorDisciplinas.Where(pd => pd.DisciplinaId == disciplinaId).ToList();
        }

        public void AddTurmaDisciplina(int turmaId, int disciplinaId, bool isBugged = false)
        {
            if (!_context.TurmaDisciplinas.Any(td => td.TurmaId == turmaId &&
            td.DisciplinaId == disciplinaId))
            {
                _context.TurmaDisciplinas.Add(new TurmaDisciplina()
                {
                    TurmaId = turmaId,
                    DisciplinaId = disciplinaId,
                });

                if (!isBugged)
                {
                    _context.SaveChanges();
                }
            }
        }

        public void RemoveTurmaDisciplina(int turmaId, int disciplinaId, bool isBugged = false)
        {
            var td = _context.TurmaDisciplinas.Find(turmaId, disciplinaId);

            if (td != null)
            {
                _context.TurmaDisciplinas.Remove(td);

                if (!isBugged)
                {
                    _context.SaveChanges();
                }
            }
        }

        public List<TurmaDisciplina> FindAllTurmaDisciplinaByDisciplina(int disciplinaId)
        {
            return _context.TurmaDisciplinas.Where(td => td.DisciplinaId == disciplinaId).ToList();
        }
    }
}
