using System;
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
        public DateTime DataNascimento { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public List<ProfessorDisciplina> ProfessorDisciplinas { get; set; } = new List<ProfessorDisciplina>();
        public List<TurmaProfessor> TurmaProfessores { get; set; } = new List<TurmaProfessor>();

        public Professor(string nome, string cpf, string rg, DateTime dataNascimento,
            string telefoneResidencial, string telefoneCelular, string email)
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            TelefoneResidencial = telefoneResidencial;
            TelefoneCelular = telefoneCelular;
            Email = email;
        }
    }
}
