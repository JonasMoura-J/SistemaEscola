using System;
using System.Linq;
using System.Collections.Generic;
using SistemaEscola.Entities;

namespace SistemaEscola.Data
{
    class SeedingService
    {
        readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

        public void Seed()
        {
            if (_context.Alunos.Any() || _context.Professores.Any() || _context.Disciplinas.Any()
                || _context.Turmas.Any() || _context.Usuarios.Any())
            {
                return;
            }

            Aluno a1 = new Aluno("JOAO AUGUSTO", "12345678910", "4312312345",
                DateTime.Parse("12/22/2222"), "23451123",
                "912341234", "joao@gmail.com", "0321323", string.Empty, "Maria");
            Aluno a2 = new Aluno("MARIA DA SILVA", "64734664743", "7665092996",
                DateTime.Parse("12/22/2222"), "66543213",
                "923672345", "mari@gmail.com", "2839102", "Miguel");
            Aluno a3 = new Aluno("MIGUEL WAWRZASZEK", "00594837251", "2283011830",
                DateTime.Parse("12/22/2222"), "22550594",
                "900339283", "migueleocara@gmail.com", "9932432", "Unknown");
            Aluno a4 = new Aluno("ALBERTO WAWRZASZEK", "00394857151", "2283011830",
                DateTime.Parse("12/22/2222"), "22543594",
                "900339283", "albertftw@gmail.com", "9952432",  "Unknown");

            Professor p1 = new Professor("LEO", "00483923812", "9233813048", DateTime.Parse("02-02-1980"),
                "46382917", "928371164", "leoprof@gmail.com");
            Professor p2 = new Professor("ALE", "93820128553", "1188372048", DateTime.Parse("02-02-1980"),
                "09382837", "955774488", "aleprof@gmail.com");
            Professor p3 = new Professor("THY", "77424678911", "6654356776", DateTime.Parse("02-02-1980"),
                "12342231", "922335463", "thygamer@gmail.com");

            Turma t1 = new Turma("03A3N", "7° ANO", 20);
            Turma t2 = new Turma("01A4N", "8° ANO", 14);
            Turma t3 = new Turma("08A1N", "9° ANO", 3);

            Disciplina d1 = new Disciplina("MATEMATICA");
            Disciplina d2 = new Disciplina("PORTUGUES");
            Disciplina d3 = new Disciplina("BIOLOGIA");

            Usuario u1 = new Usuario("COORDENACAO", "123456");
            Usuario u2 = new Usuario("PROFESSOR", "123456789");

            Avaliacao av1 = new Avaliacao() { Nome = "AV1" };
            Avaliacao av2 = new Avaliacao() { Nome = "AV2" };

            List<Aluno> alunos = new List<Aluno>() { a1, a2, a3, a4 };
            List<Professor> professores = new List<Professor>() { p1, p2, p3 };
            List<Turma> turmas = new List<Turma>() { t1, t2, t3 };
            List<Disciplina> disciplinas = new List<Disciplina>() { d1, d2, d3 };
            List<Usuario> usuarios = new List<Usuario>() { u1, u2 };
            List<Avaliacao> avaliacoes = new List<Avaliacao>() { av1, av2 };

            // Insert in Db
            alunos.ForEach(a => _context.Alunos.Add(a));
            professores.ForEach(p => _context.Professores.Add(p));
            turmas.ForEach(t => _context.Turmas.Add(t));
            disciplinas.ForEach(d => _context.Disciplinas.Add(d));
            usuarios.ForEach(u => _context.Usuarios.Add(u));
            avaliacoes.ForEach(av => _context.Avaliacoes.Add(av));

            _context.SaveChanges();
        }
    }
}
