using System.Collections.Generic;
using SistemaEscola.Entities.JoinClasses;

namespace SistemaEscola.Entities
{
    class Turma : IEntity
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int QuantidadeAlunos { get; set; }
        public List<AlunoTurma> AlunoTurmas { get; set; } = new List<AlunoTurma>();
        public List<TurmaDisciplina> TurmaDisciplinas { get; set; } = new List<TurmaDisciplina>();
        public List<TurmaProfessor> TurmaProfessores { get; set; } = new List<TurmaProfessor>();

        public Turma(string codigo, string nome, int quantidadeAlunos)
        {
            Codigo = codigo;
            Nome = nome;
            QuantidadeAlunos = quantidadeAlunos;
        }
    }
}
