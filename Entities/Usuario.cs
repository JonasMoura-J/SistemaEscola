namespace SistemaEscola.Entities
{
    class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Usuario(int id, string nome, string senha)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
        }
    }
}
