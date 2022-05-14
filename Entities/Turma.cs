using System.Collections.Generic;

namespace SistemaEscola.Entities
{
    class Turma
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int QuantidadeAlunos { get; set; }
        public List<Aluno> MyProperty { get; set; } = new List<Aluno>();
    }
}
