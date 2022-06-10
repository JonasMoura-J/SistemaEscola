using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscola.Entities.Formularios
{
    public class FormularioDisciplina : IFormulario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nome { get; set; }
        public List<FormularioProfessor> FormularioProfessores = new List<FormularioProfessor>();
        public List<FormularioTurma> FormularioTurmas = new List<FormularioTurma>();
    }
}
