using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Parsers;

namespace SistemaEscola.Controllers
{
    class ControladorProfessor : IController<Professor>
    {
        private readonly TempDb _context = TempDb.Instanse;

        private readonly ControladorDisciplina _controladorDisciplina = new ControladorDisciplina();
        private readonly ControladorUsuario _controladorUsuario = new ControladorUsuario();

        public void Add(FormularioProfessor form)
        {
            // Check if Professor already exists
            if (FindAll().Any(d => d.Cpf == form.Cpf || d.Email == form.Email))
            {
                throw new Exception("Professor já cadastrado");
            }

            // Prepares the lists of Disciplinas and Alunos
            var disciplinasToInsert = new List<Disciplina>();

            foreach (string disc in form.Disciplinas)
            {
                disciplinasToInsert.Add(_controladorDisciplina.FindByName(disc));
            }

            // Adds new Professor to Db
            var professor = new Professor(form.Id, form.Nome, CpfParse.ToNumber(form.Cpf),
                RgParse.ToNumber(form.Rg), PhoneNumberParse.ToNumber(form.TelefoneResidencial),
                PhoneNumberParse.ToNumber(form.TelefoneCelular), form.Email,
                disciplinasToInsert);

            _context.Professores.Add(professor);

            // Updates Disciplina with new data
            disciplinasToInsert.ForEach(a => a.AddProfessor(professor));

            // Creates a new user profile
            var usuario = new FormularioUsuario
            {
                Nome = professor.Cpf,
                Senha = professor.Cpf
            };

            _controladorUsuario.Add(usuario);
        }

        public List<Professor> FindAll()
        {
            return _context.Professores;
        }

        public void Delete(int Id)
        {
            Professor professor = FindById(Id);

            if (professor != null) {
                _context.Professores.Remove(professor);
            }

        }

        // Not working for now
        public void Update(FormularioProfessor form)
        {
            Professor professor = FindById(form.Id);

            if (professor != null) {

                _context.Professores.Remove(professor);
                //_context.Professores.Add(new Professor(form.Id, form.Nome, form.Cpf,
                //form.Rg, form.TelefoneResidencial, form.TelefoneCelular, form.Email));
            }
        }

        public Professor FindById(int Id)
        {
            return _context.Professores.Find(x => x.Id == Id);
        }
    }
}
