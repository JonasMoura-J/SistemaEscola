using System.Collections.Generic;
using SistemaEscola.Entities.JoinClasses;

namespace SistemaEscola.Entities
{
    class Disciplina : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<ProfessorDisciplina> ProfessorDisciplinas { get; set; } = new List<ProfessorDisciplina>();
        public List<TurmaDisciplina> TurmaDisciplinas { get; set; } = new List<TurmaDisciplina>();
        public List<AlunoFaltaDisciplina> AlunoFaltaDisciplinas { get; set; } = new List<AlunoFaltaDisciplina>();

        public Disciplina(string nome)
        {
            Nome = nome;
        }
    }
}
