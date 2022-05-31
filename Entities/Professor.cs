using System.Collections.Generic;
using SistemaEscola.Entities.JoinClasses;

namespace SistemaEscola.Entities
{
    class Professor : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public List<ProfessorDisciplina> ProfessorDisciplinas { get; set; } = new List<ProfessorDisciplina>();
        public List<TurmaProfessor> TurmaProfessores { get; set; } = new List<TurmaProfessor>();

        public Professor(string nome, string cpf, string rg,
            string telefoneResidencial, string telefoneCelular, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            TelefoneResidencial = telefoneResidencial;
            TelefoneCelular = telefoneCelular;
            Email = email;
        }

        public void InsertDisciplinas(List<Disciplina> disciplinas)
        {
            disciplinas.ForEach(d => ProfessorDisciplinas.Add(new ProfessorDisciplina {
                ProfessorId = Id,
                DisciplinaId = d.Id,
                Professor = this,
                Disciplina = d
            }));
        }
    }
}
