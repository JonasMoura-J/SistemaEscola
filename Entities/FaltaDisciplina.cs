namespace SistemaEscola.Entities
{
    class FaltaDisciplina
    {
        public Disciplina Disciplina { get; set; }
        public int Faltas { get; set; } = 0;
    }
}
