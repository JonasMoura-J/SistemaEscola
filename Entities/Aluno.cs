using System;
using System.Collections.Generic;

namespace SistemaEscola.Entities
{
    class Aluno
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
        public List<Disciplina> Disciplinas { get; set; }

        public Aluno(int id, string nome, string cpf, string rg, DateTime dataNascimento, 
            string telefoneResidencial, string telefoneCelular, string email,
            string matricula, string nomePai = null, string nomeMae = null,
            string nomeResponsavel = null)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            DataNascimento = dataNascimento;
            TelefoneResidencial = telefoneResidencial;
            TelefoneCelular = telefoneCelular;
            Email = email;
            NomePai = nomePai;
            NomeMae = nomeMae;
            NomeResponsavel = nomeResponsavel;
            Matricula = matricula;
        }
    }
}
