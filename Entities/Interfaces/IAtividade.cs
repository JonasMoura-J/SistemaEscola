using System.Collections.Generic;
using SistemaEscola.Entities.JoinClasses;

namespace SistemaEscola.Entities.Interfaces
{
    interface IAtividade
    {
        int Id { get; set; }
        string Nome { get; set; }
        int Nota { get; set; }
        List<AvaliacaoAtividade> AvaliacaoAtividades { get; set; }
    }
}
