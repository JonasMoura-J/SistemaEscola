using System;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Validations;

namespace SistemaEscola.Entities.Formularios
{
    public class FormularioAluno : IFormulario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nome { get; set; }
        [Required, Cpf, Display(Name = "CPF")]
        public string Cpf { get; set; }
        [Required, Display(Name = "RG")]
        public string Rg { get; set; }
        [Required, Date("01/01/2000"), Display(Name = "Data de Nascimento")] // set proper date later
        public DateTime DataNascimento { get; set; }
        [PhoneNumber, Display(Name = "Telefone Residencial")]
        public string TelefoneResidencial { get; set; }
        [MobilePhoneNumber, Display(Name = "Telefone Celular")]
        public string TelefoneCelular { get; set; }
        [Required, EmailAddress, Display(Name = "E-mail")]
        public string Email { get; set; }
        [StringLength(100), Display(Name = "Nome do Pai")]
        public string NomePai { get; set; }
        [StringLength(100), Display(Name = "Nome da Mãe")]
        public string NomeMae { get; set; }
        [StringLength(100), Display(Name = "Nome do Responsável")]
        public string NomeResponsavel { get; set; }
        [Required, Display(Name = "Matrícula")]
        public string Matricula { get; set; }
        public int? TurmaId { get; set; }
    }
}
