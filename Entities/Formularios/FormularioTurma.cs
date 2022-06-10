using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaEscola.Entities.Formularios
{
    public class FormularioTurma : IFormulario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nome { get; set; }
        [Required, Display(Name = "Código")]
        public string Codigo { get; set; }
        public List<string> Disciplinas { get; set; }
        public List<string> Alunos { get; set; }
        public int QuantidadeAlunos { get; set; }
    }
}
