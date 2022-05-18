using System.ComponentModel.DataAnnotations;

namespace SistemaEscola.Entities.Formularios
{
    class Formulario
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
