using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscola.Entities.Formularios
{
    class FormularioProfessor : IFormulario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public List<Turma> Turmas { get; set; } = new List<Turma>();
    }
}
