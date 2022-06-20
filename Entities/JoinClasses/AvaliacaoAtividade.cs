namespace SistemaEscola.Entities.JoinClasses
{
    class AvaliacaoAtividade
    {
        public int AvaliacaoId { get; set; }
        public int AtividadeId { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public Atividade Atividade { get; set; }
    }
}
