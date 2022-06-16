using System;
using System.Linq;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Entities.JoinClasses;
using SistemaEscola.Entities;
using SistemaEscola.Parsers;
using SistemaEscola.Data;

namespace SistemaEscola.Controllers
{
    class ControladorProfessor : IController<Professor>
    {
        readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

        public static readonly ControladorProfessor Instance = new ControladorProfessor();
        
        readonly ControladorUsuario _controladorUsuario = new ControladorUsuario();

        public void Add(FormularioProfessor form)
        {
            // Check if Professor already exists
            if (FindAll().Any(d => CpfParse.ToDigit(d.Cpf) == form.Cpf || d.Email == form.Email))
            {
                throw new Exception("Professor já cadastrado");
            }

            // Adds new Professor to Db
            InsertIntoDb(form);

            // Updates disciplinas
            UpdateProfessorDisciplinas(form, true);

            /*
            // Creates a new user profile
            var usuario = new FormularioUsuario
            {
                Nome = professor.Cpf,
                Senha = professor.Cpf
            };

            _controladorUsuario.Add(usuario);
            */
        }

        public void InsertIntoDb(FormularioProfessor form)
        {
            var professor = new Professor(form.Nome, CpfParse.ToNumber(form.Cpf),
                form.Rg, form.DataNascimento,
                PhoneNumberParse.ToNumber(form.TelefoneResidencial),
                PhoneNumberParse.ToNumber(form.TelefoneCelular), form.Email);

            _context.Professores.Add(professor);
            _context.SaveChanges();
        }

        public List<Professor> FindAll()
        {
            return _context.Professores.OrderBy(p => p.Nome).ToList();
        }

        public Professor FindById(int id)
        {
            var professor = _context.Professores.Find(id);

            if (professor == null)
            {
                return null;
            }

            return professor;
        }

        public Professor FindByCpf(string cpf)
        {
            var professor = _context.Professores.Where(p => p.Cpf == CpfParse.ToNumber(cpf));

            if (!professor.Any())
            {
                return null;
            }

            return professor.First();
        }

        public Professor FindByName(string name)
        {
            var professor = _context.Professores.Where(p => p.Nome == name);

            if (!professor.Any())
            {
                return null;
            }

            return professor.First();
        }

        public void Update(FormularioProfessor form)
        {
            Professor professor = FindById(form.Id);

            if (professor != null)
            {
                // Updates Professor
                professor.Nome = form.Nome;
                professor.Cpf = CpfParse.ToNumber(form.Cpf);
                professor.Rg = form.Rg;
                professor.DataNascimento = form.DataNascimento;
                professor.TelefoneResidencial = PhoneNumberParse.ToNumber(form.TelefoneResidencial);
                professor.TelefoneCelular = PhoneNumberParse.ToNumber(form.TelefoneCelular);
                professor.Email = form.Email;

                // Updates disciplinas
                UpdateProfessorDisciplinas(form);

                // Updates turmas
                UpdateTurmaProfessores(form);

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Professor professor = FindById(id);

            if (professor != null) {
                _context.Professores.Remove(professor);
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

        public void UpdateProfessorDisciplinas(FormularioProfessor form, bool saveChanges = false)
        {
            var professorId = form.Id;

            if (professorId == 0)
            {
                //professorId = FindByCpf(form.Cpf).Id;
                professorId = FindByName(form.Nome).Id; // Only works with name for some reason
            }
            
            var professorDisciplinas = FindAllProfessorDisciplinasByProfessor(professorId);

            foreach (var fd in form.FormularioDisciplinas)
            {
                if (!professorDisciplinas.Any(pd => pd.DisciplinaId == fd.Id))
                {
                    AddProfessorDisciplina(professorId, fd.Id);
                }
            }

            foreach (var pd in professorDisciplinas)
            {
                if (!form.FormularioDisciplinas.Any(fd => fd.Id == pd.DisciplinaId))
                {
                    RemoveProfessorDisciplina(pd.ProfessorId, pd.DisciplinaId);
                }
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<ProfessorDisciplina> FindAllProfessorDisciplinasByProfessor(int professorId)
        {
            return _context.ProfessorDisciplinas.Where(pd => pd.ProfessorId == professorId).ToList();
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

        public void UpdateTurmaProfessores(FormularioProfessor form, bool saveChanges = false)
        {
            var professorId = form.Id;

            if (professorId == 0)
            {
                professorId = FindByName(form.Nome).Id;
            }

            var turmaProfessores = FindAllTurmaProfessoresByProfessor(professorId);

            foreach (var ft in form.FormularioTurmas)
            {
                if (!turmaProfessores.Any(tp => tp.TurmaId == ft.Id))
                {
                    AddTurmaProfessor(ft.Id, professorId);
                }
            }

            foreach (var tp in turmaProfessores)
            {
                if (!form.FormularioTurmas.Any(ft => ft.Id == tp.TurmaId))
                {
                    RemoveTurmaProfessor(tp.TurmaId, tp.ProfessorId);
                }
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public List<TurmaProfessor> FindAllTurmaProfessoresByProfessor(int professorId)
        {
            return _context.TurmaProfessores.Where(tp => tp.ProfessorId == professorId).ToList();
        }
    }
}
