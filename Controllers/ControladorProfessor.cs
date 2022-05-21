using System.Collections.Generic;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorProfessor : IController<Professor>
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
            Professor professor = FindById(Id);

            if (professor != null) {
                _context.Professores.Remove(professor);
            }

        }

        public void Update(FormularioProfessor form)
        {
            Professor professor = FindById(form.Id);

            if (professor != null) {

                _context.Professores.Remove(professor);
                _context.Professores.Add(new Professor(form.Id, form.Nome, form.Cpf,
                form.Rg, form.TelefoneResidencial, form.TelefoneCelular, form.Email));
            }
        }

        public Professor FindById(int Id)
        {
            return _context.Professores.Find(x => x.Id == Id);
        }
    }
}
