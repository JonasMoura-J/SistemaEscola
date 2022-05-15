using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorDisciplina
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void AddDisciplina(FormularioDisciplina form)
        {
            _context.Disciplinas.Add(new Disciplina(form.Id, form.Nome));
        }
    }
}
