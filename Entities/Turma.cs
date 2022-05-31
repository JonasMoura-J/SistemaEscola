using SistemaEscola.Entities.JoinClasses;
using System.Collections.Generic;

namespace SistemaEscola.Entities
{
    class Turma : IEntity
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int QuantidadeAlunos { get; set; }
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public List<TurmaDisciplina> TurmaDisciplinas { get; set; } = new List<TurmaDisciplina>();
        public List<TurmaProfessor> TurmaProfessores { get; set; } = new List<TurmaProfessor>();

        public Turma(string codigo, string nome, int quantidadeAlunos)
        {
            Codigo = codigo;
            Nome = nome;
            QuantidadeAlunos = quantidadeAlunos;
        }

        public void InsertAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void InsertDisciplinas(List<Disciplina> disciplinas)
        {
            disciplinas.ForEach(d => TurmaDisciplinas.Add(new TurmaDisciplina
            {
                TurmaId = Id,
                DisciplinaId = d.Id,
                Turma = this,
                Disciplina = d
            }));
        }
    }
}
