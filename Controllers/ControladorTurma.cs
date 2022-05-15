using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorTurma
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void AddTurma(FormularioTurma form)
        {
            _context.Turmas.Add(new Turma(form.Id, form.Codigo, form.Nome, form.QuantidadeAlunos));
        }
    }
}
