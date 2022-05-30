namespace SistemaEscola.Entities.JoinClasses
{
    class AlunoFaltaDisciplina
    {
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
        public int Faltas { get; set; } = 0;
    }
}
