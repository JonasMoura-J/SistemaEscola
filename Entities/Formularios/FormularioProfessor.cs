using System.Collections.Generic;

namespace SistemaEscola.Entities.Formularios
{
    class FormularioProfessor : Formulario
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public List<Turma> Turmas { get; set; } = new List<Turma>();
    }
}
