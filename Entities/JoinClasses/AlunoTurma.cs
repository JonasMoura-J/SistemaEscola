﻿namespace SistemaEscola.Entities.JoinClasses
{
    class AlunoTurma
    {
        public int AlunoId { get; set; }
        public int TurmaId { get; set; }
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }
    }
}
