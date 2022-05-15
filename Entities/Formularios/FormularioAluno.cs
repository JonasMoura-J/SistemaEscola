namespace SistemaEscola.Entities.Formularios
{
    class FormularioAluno : Formulario
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public string NomeResponsavel { get; set; }
        public string Matricula { get; set; }
    }
}
