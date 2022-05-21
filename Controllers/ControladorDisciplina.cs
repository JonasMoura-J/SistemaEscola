using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorDisciplina : IController<Disciplina>
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void Add(FormularioDisciplina form)
        {
            if (FindAll().Any(d => d.Nome == form.Nome))
            {
                throw new Exception("Disciplina já cadastrada");
            }

            _context.Disciplinas.Add(new Disciplina(form.Id, form.Nome));
        }

        public List<Disciplina> FindAll()
        {
            return _context.Disciplinas;
        }

        public void Delete(int Id)
        {
            Disciplina disciplina = FindById(Id);

            if (disciplina != null) 
            {
                _context.Disciplinas.Remove(disciplina);
            }
            
        }

        public void Update(FormularioDisciplina form)
        {
            Disciplina disciplina = FindById(form.Id);

            if (disciplina != null) {

                _context.Disciplinas.Remove(disciplina);
                _context.Disciplinas.Add(new Disciplina(form.Id, form.Nome));
            }
        }

        public Disciplina FindById(int Id)
        {
            return _context.Disciplinas.Find(x => x.Id == Id);
        }
    }
}
