namespace SistemaEscola.Entities
{
    class FaltaDisciplina
    {
        public int Id { get; set; }
        public Disciplina Disciplina { get; set; }
        public int Faltas { get; set; } = 0;
    }
}
