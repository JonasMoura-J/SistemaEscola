namespace SistemaEscola.Entities.JoinClasses
{
    class ProfessorDisciplina
    {
        public int ProfessorId { get; set; }
        public int DisciplinaId { get; set; }
        public Professor Professor { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
