using System;

namespace SistemaEscola.Entities
{
    class Trabalho : Atividade
    {
        public string Descricao { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataEntrega { get; set; }
    }
}
