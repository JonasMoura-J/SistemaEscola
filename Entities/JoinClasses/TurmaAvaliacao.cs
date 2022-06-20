namespace SistemaEscola.Entities.JoinClasses
{
    class TurmaAvaliacao
    {
        public int TurmaId { get; set; }
        public int AvaliacaoId { get; set; }
        public Turma Turma { get; set; }
        public Avaliacao Avaliacao { get; set; }
    }
}
