using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Validations;

namespace SistemaEscola.Entities.Formularios
{
    public class FormularioProfessor : IFormulario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nome { get; set; }
        [Required, Cpf, Display(Name = "CPF")]
        public string Cpf { get; set; }
        [Required, Display(Name = "RG")]
        public string Rg { get; set; }
        [Required, Date("01/01/1940"), Display(Name = "Data de Nascimento")] // set proper date later
        public DateTime DataNascimento { get; set; }
        [PhoneNumber, Display(Name = "Telefone Residencial")]
        public string TelefoneResidencial { get; set; }
        [MobilePhoneNumber, Display(Name = "Telefone Celular")]
        public string TelefoneCelular { get; set; }
        [Required, EmailAddress, Display(Name = "E-mail")]
        public string Email { get; set; }
        public List<FormularioDisciplina> FormularioDisciplinas = new List<FormularioDisciplina>();
        public List<FormularioTurma> FormularioTurmas = new List<FormularioTurma>();
    }
}
