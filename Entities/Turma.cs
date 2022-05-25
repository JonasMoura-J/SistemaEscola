using System.Collections.Generic;

namespace SistemaEscola.Entities
{
    class Turma : IEntity
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int QuantidadeAlunos { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Disciplina> Disciplinas { get; set; }

        public Turma(int id, string codigo, string nome, int quantidadeAlunos,
            List<Aluno> alunos, List<Disciplina> disciplinas)
        {
            Id = id;
            Codigo = codigo;
            Nome = nome;
            QuantidadeAlunos = quantidadeAlunos;
            Alunos = alunos;
            Disciplinas = disciplinas;
        }
    }
}
