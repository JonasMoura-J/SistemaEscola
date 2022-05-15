using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorProfessor
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void AddProfessor(FormularioProfessor form)
        {
            _context.Professores.Add(new Professor(form.Id, form.Nome, form.Cpf,
                form.Rg, form.TelefoneResidencial, form.TelefoneCelular, form.Email));
        }
    }
}
