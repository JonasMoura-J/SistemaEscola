using System.Collections.Generic;

namespace SistemaEscola.Entities.Formularios
{
    class FormularioDisciplina : Formulario
    {
        public List<Professor> Professores { get; set; } = new List<Professor>();
    }
}
