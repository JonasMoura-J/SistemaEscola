namespace SistemaEscola.Entities.JoinClasses
{
    class TurmaProfessor
    {
        public int TurmaId { get; set; }
        public int ProfessorId { get; set; }
        public Turma Turma { get; set; }
        public Professor Professor { get; set; }
    }
}
