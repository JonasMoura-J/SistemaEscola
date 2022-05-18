using System.ComponentModel.DataAnnotations;

namespace SistemaEscola.Entities.Formularios
{
    class Formulario
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$"), StringLength(100, MinimumLength = 2)]
        public string Nome { get; set; }
    }
}
