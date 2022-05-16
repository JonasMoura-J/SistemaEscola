using System.Collections.Generic;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorDisciplina
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void Add(FormularioDisciplina form)
        {
            _context.Disciplinas.Add(new Disciplina(form.Id, form.Nome));
        }

        public List<Disciplina> FindAll()
        {
            return _context.Disciplinas;
        }
    }
}
