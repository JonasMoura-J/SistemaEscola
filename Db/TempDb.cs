using System;
using System.Collections.Generic;
using SistemaEscola.Entities;

namespace SistemaEscola.Db
{
    sealed class TempDb
    {
        public static readonly TempDb Instanse = new TempDb();
        public List<Aluno> Alunos { get; set; } = new List<Aluno>();
        public List<Professor> Professores { get; set; } = new List<Professor>();
        public List<Turma> Turmas { get; set; } = new List<Turma>();
        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();

        private TempDb()
        {
            Alunos.Add(new Aluno(1, "Joao", "12345678910", "4312312345",
                DateTime.Parse("12/22/2222"), "23451123",
                "912341234", "joao@gmail.com", "Maria", "0321323"));
            Alunos.Add(new Aluno(2, "Maria", "64734664743", "7665092996",
                DateTime.Parse("12/22/2222"), "66543213",
                "923672345", "mari@gmail.com", "Miguel", "2839102"));
            Alunos.Add(new Aluno(3, "Miguel", "00594837251", "2283011830",
                DateTime.Parse("12/22/2222"), "22550594",
                "900339283", "migueleocara@gmail.com", "Unknown", "9932432"));

            Professores.Add(new Professor(1, "Leo", "00483923812", "9233813048", "46382917",
                "928371164", "leoprof@gmail.com"));
            Professores.Add(new Professor(2, "Ale", "93820128553", "1188372048", "09382837",
                "955774488", "aleprof@gmail.com"));
            Professores.Add(new Professor(3, "Thy", "77424678911", "6654356776", "12342231",
                "922335463", "thygamer@gmail.com"));

            Turmas.Add(new Turma(1, "03A3N", "7° ano", 20));
            Turmas.Add(new Turma(2, "01A4N", "8° ano", 14));
            Turmas.Add(new Turma(3, "08A1N", "9° ano", 3));

            Disciplinas.Add(new Disciplina(1, "Matematica"));
            Disciplinas.Add(new Disciplina(2, "Portugues"));
            Disciplinas.Add(new Disciplina(3, "Biologia"));

            Usuarios.Add(new Usuario("Coordenacao", "123456"));
            Usuarios.Add(new Usuario("Professor", "123456789"));
        }
    }
}
