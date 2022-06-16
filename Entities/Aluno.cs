using System;
using System.Collections.Generic;
using SistemaEscola.Entities.JoinClasses;

namespace SistemaEscola.Entities
{
    class Aluno : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string NomeResponsavel { get; set; }
        public string Matricula { get; set; }
        public List<AlunoTurma> AlunoTurmas { get; set; } = new List<AlunoTurma>();
        public List<AlunoFaltaDisciplina> AlunoFaltaDisciplinas { get; set; } = new List<AlunoFaltaDisciplina>();

        public Aluno(string nome, string cpf, string rg, DateTime dataNascimento, 
            string telefoneResidencial, string telefoneCelular, string email,
            string matricula, string nomePai = "", string nomeMae = "",
            string nomeResponsavel = "")
        {
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            TelefoneResidencial = telefoneResidencial;
            TelefoneCelular = telefoneCelular;
            Email = email;
            Matricula = matricula;
            NomePai = nomePai;
            NomeMae = nomeMae;
            NomeResponsavel = nomeResponsavel;
        }
    }
}
