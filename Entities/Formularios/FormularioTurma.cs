using System.ComponentModel.DataAnnotations;

namespace SistemaEscola.Entities.Formularios
{
    class FormularioTurma : IFormulario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public int QuantidadeAlunos { get; set; }
    }
}
