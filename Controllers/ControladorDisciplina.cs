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

        public void Delete(int Id)
        {
            Disciplina disciplina = Find(Id);

            if (disciplina != null) 
            {
                _context.Disciplinas.Remove(disciplina);
            }
            
        }

        public void Update(FormularioDisciplina form)
        {
            Disciplina disciplina = Find(form.Id);

            if (disciplina != null) {

                _context.Disciplinas.Remove(disciplina);
                _context.Disciplinas.Add(new Disciplina(form.Id, form.Nome));
            }
        }

        public Disciplina Find(int Id)
        {
            return _context.Disciplinas.Find(x => x.Id == Id);
        }
    }
}
