namespace SistemaEscola.Entities
{
    class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }
    }
}
