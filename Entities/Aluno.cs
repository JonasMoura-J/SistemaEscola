using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscola.Entities
{
    class Aluno
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public string Rg { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public string TelefoneResidencial { get; set; }
        [Required]
        public string TelefoneCelular { get; set; }
        [Required]
        public string Email { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string NomeResponsavel { get; set; }
        [Required]
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
