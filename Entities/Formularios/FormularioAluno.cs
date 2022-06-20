using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Validations;

namespace SistemaEscola.Entities.Formularios
{
    public class FormularioAluno : IFormulario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Nome deve conter de 2 a 100 caracteres.")]
        public string Nome { get; set; }
        [Required, Cpf]
        public string Cpf { get; set; }
        [Required]
        public string Rg { get; set; }
        [Required, Date("01/01/1950", "01/01/2018")]
        public DateTime DataNascimento { get; set; }
        [PhoneNumber]
        public string TelefoneResidencial { get; set; }
        [MobilePhoneNumber]
        public string TelefoneCelular { get; set; }
        [Required, EmailAddress(ErrorMessage = "Endereço de e-mail inválido.")]
        public string Email { get; set; }
        [StringLength(100), Display(Name = "Nome do Pai")]
        public string NomePai { get; set; }
        [StringLength(100), Display(Name = "Nome da Mãe")]
        public string NomeMae { get; set; }
        [StringLength(100), Display(Name = "Nome do Responsável")]
        public string NomeResponsavel { get; set; }
        [Required, Display(Name = "Matrícula")]
        public string Matricula { get; set; }
        public List<FormularioDisciplina> FormularioDisciplinas = new List<FormularioDisciplina>();
        public FormularioTurma FormularioTurma = new FormularioTurma();
    }
}
