using System;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Validations;

namespace SistemaEscola.Entities.Formularios
{
    class FormularioAluno : Formulario
    {
        [Required, Cpf]
        public string Cpf { get; set; }
        [Required, Rg]
        public string Rg { get; set; }
        [Required, Date("01/01/2000")] // set proper date later
        public DateTime DataNascimento { get; set; }
        [PhoneNumber]
        public string TelefoneResidencial { get; set; }
        [MobilePhoneNumber]
        public string TelefoneCelular { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [StringLength(100)]
        public string NomePai { get; set; }
        [StringLength(100)]
        public string NomeMae { get; set; }
        [StringLength(100)]
        public string NomeResponsavel { get; set; }
        [Required]
        public string Matricula { get; set; }
    }
}
