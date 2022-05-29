using SistemaEscola.Entities.JoinClasses;
using System.Collections.Generic;
using System.Linq;

namespace SistemaEscola.Entities
{
    class Disciplina : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<ProfessorDisciplina> ProfessorDisciplinas { get; set; } = new List<ProfessorDisciplina>();

        public Disciplina(string nome)
        {
            Nome = nome;
        }

        public void AddProfessor(Professor professor)
        {
            if (!ProfessorDisciplinas.Any(d => d.ProfessorId == professor.Id))
            {
                ProfessorDisciplinas.Add(new ProfessorDisciplina {
                    ProfessorId = professor.Id,
                    DisciplinaId = Id,
                    Professor = professor,
                    Disciplina = this
                });
            }
        }

        public void RemoveProfessor(Professor professor)
        {
            if (ProfessorDisciplinas.Any(d => d.ProfessorId == professor.Id))
            {
                var profToRemove = ProfessorDisciplinas.Where(d => d.ProfessorId == professor.Id).First();

                ProfessorDisciplinas.Remove(profToRemove);
            }
        }
    }
}
