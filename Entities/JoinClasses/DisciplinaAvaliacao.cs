namespace SistemaEscola.Entities.JoinClasses
{
    class DisciplinaAvaliacao
    {
        public int DisciplinaId { get; set; }
        public int AvaliacaoId { get; set; }
        public Disciplina Disciplina { get; set; }
        public Avaliacao Avaliacao { get; set; }
    }
}
