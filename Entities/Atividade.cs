using System.Collections.Generic;
using SistemaEscola.Entities.JoinClasses;
using SistemaEscola.Entities.Interfaces;

namespace SistemaEscola.Entities
{
    class Atividade : IAtividade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Nota { get; set; }
        public List<AvaliacaoAtividade> AvaliacaoAtividades { get; set; } = new List<AvaliacaoAtividade>();
    }
}
