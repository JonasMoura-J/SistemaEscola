using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscola.Entities.Formularios
{
    class FormularioDisciplina : IFormulario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nome { get; set; }
        public List<Professor> Professores { get; set; } = new List<Professor>();
    }
}
