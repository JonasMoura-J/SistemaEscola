using System.Collections.Generic;
using SistemaEscola.Entities.JoinClasses;
using SistemaEscola.Entities.Interfaces;

namespace SistemaEscola.Entities
{
    class Avaliacao : IAtividade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Nota { get; set; }
        public string Descricao { get; set; }
        public List<AvaliacaoAtividade> AvaliacaoAtividades { get; set; } = new List<AvaliacaoAtividade>();
        public List<TurmaAvaliacao> TurmaAvaliacoes { get; set; } = new List<TurmaAvaliacao>();
        public List<DisciplinaAvaliacao> DisciplinaAvaliacoes { get; set; } = new List<DisciplinaAvaliacao>();
    }
}
