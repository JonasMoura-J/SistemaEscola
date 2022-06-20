using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscola.Entities.Formularios
{
    public class FormularioTurma : IFormulario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Nome deve conter de 2 a 100 caracteres.")]
        public string Nome { get; set; }
        [Required]
        public string Codigo { get; set; }
        public List<FormularioAluno> FormularioAlunos { get; set; }
        public List<FormularioDisciplina> FormularioDisciplinas { get; set; }
        public List<FormularioProfessor> FormularioProfessores { get; set; }
        public int QuantidadeAlunos { get; set; }
    }
}
