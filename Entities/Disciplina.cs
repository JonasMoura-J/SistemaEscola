using System.Collections.Generic;
using System.Linq;

namespace SistemaEscola.Entities
{
    class Disciplina : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Professor> Professores { get; set; } = new List<Professor>();

        public Disciplina(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddProfessor(Professor professor)
        {
            if (!Professores.Any(d => d.Id == professor.Id))
            {
                Professores.Add(professor);
            }
        }

        public void RemoveProfessor(Professor professor)
        {
            if (Professores.Any(d => d.Id == professor.Id))
            {
                Professores.Remove(professor);
            }
        }
    }
}
