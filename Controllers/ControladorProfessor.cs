using System.Collections.Generic;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorProfessor
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void Add(FormularioProfessor form)
        {
            _context.Professores.Add(new Professor(form.Id, form.Nome, form.Cpf,
                form.Rg, form.TelefoneResidencial, form.TelefoneCelular, form.Email));
        }

        public List<Professor> FindAll()
        {
            return _context.Professores;
        }

        public void Delete(int Id)
        {
            Professor professor = Find(Id);

            if (professor != null) {
                _context.Professores.Remove(professor);
            }

        }

        public void Update(FormularioProfessor form)
        {
            Professor professor = Find(form.Id);

            if (professor != null) {

                _context.Professores.Remove(professor);
                _context.Professores.Add(new Professor(form.Id, form.Nome, form.Cpf,
                form.Rg, form.TelefoneResidencial, form.TelefoneCelular, form.Email));
            }
        }

        public Professor Find(int Id)
        {
            return _context.Professores.Find(x => x.Id == Id);
        }
    }
}
