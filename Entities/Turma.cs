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

        public Turma(string codigo, string nome, int quantidadeAlunos)
        {
            Codigo = codigo;
            Nome = nome;
            QuantidadeAlunos = quantidadeAlunos;
        }

        public void InsertDisciplinas(List<Disciplina> disciplinas)
        {
            Disciplinas = disciplinas;
        }

        public void InsertAlunos(List<Aluno> alunos)
        {
            Alunos = alunos;
        }
    }
}
