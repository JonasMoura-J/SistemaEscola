using System.Collections.Generic;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorTurma
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void Add(FormularioTurma form)
        {
            _context.Turmas.Add(new Turma(form.Id, form.Codigo, form.Nome, form.QuantidadeAlunos));
        }
        public List<Turma> FindAll()
        {
            return _context.Turmas;
        }
    }
}
