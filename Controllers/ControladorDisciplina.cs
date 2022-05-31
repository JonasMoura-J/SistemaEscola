using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Data;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorDisciplina : IController<Disciplina>
    {
        private readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

        public void Add(FormularioDisciplina form)
        {
            // Checks if Disciplina already exists
            if (FindAll().Any(d => d.Nome == form.Nome))
            {
                throw new Exception("Disciplina já cadastrada");
            }

            // Adds new Disciplina do Db
            var disciplina = new Disciplina(form.Nome);

            _context.Disciplinas.Add(disciplina);

            _context.SaveChanges();
        }

        public List<Disciplina> FindAll()
        {
            return _context.Disciplinas.OrderBy(d => d.Nome).ToList();
        }

        public Disciplina FindById(int id)
        {
            var disciplina = _context.Disciplinas.Find(id);

            if (disciplina == null)
            {
                return null;
            }

            return disciplina;
        }

        public Disciplina FindByName(string name)
        {
            var disciplina = _context.Disciplinas.Where(d => d.Nome == name);

            if (!disciplina.Any())
            {
                return null;
            }

            return disciplina.First();
        }

        public void Delete(int id)
        {
            Disciplina disciplina = FindById(id);

            if (disciplina != null) 
            {
                _context.Disciplinas.Remove(disciplina);
            }

            _context.SaveChanges();
        }

        public void Update(FormularioDisciplina form)
        {
            Disciplina disciplina = FindById(form.Id);

            if (disciplina != null) {

                _context.Disciplinas.Remove(disciplina);
                _context.Disciplinas.Add(new Disciplina(form.Nome));
            }
        }
    }
}
