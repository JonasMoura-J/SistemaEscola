using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorAluno
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void AddAluno(FormularioAluno form)
        {
            _context.Alunos.Add(new Aluno(form.Id, form.Nome, form.Cpf, form.Rg,
                form.TelefoneResidencial, form.TelefoneCelular, form.Email, form.NomeResponsavel,
                form.Matricula));
        }
    }
}
