using System.Collections.Generic;

namespace SistemaEscola.Entities
{
    class Turma
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int QuantidadeAlunos { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();

        public Turma(int id, string codigo, string nome, int quantidadeAlunos)
        {
            Id = id;
            Codigo = codigo;
            Nome = nome;
            QuantidadeAlunos = quantidadeAlunos;
        }
    }
}
