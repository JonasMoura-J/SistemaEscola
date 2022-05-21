﻿using System.Collections.Generic;

namespace SistemaEscola.Entities
{
    class Disciplina : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Professor> Professores { get; set; } = new List<Professor>();

        public Disciplina(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
