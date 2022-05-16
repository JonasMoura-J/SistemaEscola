using System.Collections.Generic;

namespace SistemaEscola.Entities
{
    class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Email { get; set; }
        public List<Turma> Turmas { get; set; } = new List<Turma>();

        public Professor(int id, string nome, string cpf, string rg,
            string telefoneResidencial, string telefoneCelular, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Rg = rg;
            TelefoneResidencial = telefoneResidencial;
            TelefoneCelular = telefoneCelular;
            Email = email;
        }
    }
}
