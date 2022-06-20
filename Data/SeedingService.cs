using System;
using System.Linq;
using System.Collections.Generic;
using SistemaEscola.Entities;
using System.Globalization;

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

            Aluno a1 = new Aluno("JOAO AUGUSTO", "09358135000", "30.045.243-3",
                DateTime.ParseExact("26/02/2005", "dd/MM/yyyy", new CultureInfo("pt-BR")),
                "2137834482", "21981907312", "joao@gmail.com", "0321323", string.Empty, "AYLA LUIZA");
            Aluno a2 = new Aluno("MARIA DA SILVA", "68640652007", "33.064.644-8",
                DateTime.ParseExact("16/04/2005", "dd/MM/yyyy", new CultureInfo("pt-BR")),
                "2437249048", "24984972029", "mary@gmail.com", "2839102", "CAUÊ MIGUEL");
            Aluno a3 = new Aluno("MIGUEL WAWRZASZEK", "80091488060", "39.585.454-4",
                DateTime.ParseExact("24/01/2008", "dd/MM/yyyy", new CultureInfo("pt-BR")),
                "2129392424", "21998497525", "migueleocara@gmail.com", "9932432", "MARCELO KAIQUE", "SARA SOPHIA");
            Aluno a4 = new Aluno("ALBERTO WAWRZASZEK", "23646078090", "10.832.435-7",
                DateTime.ParseExact("24/01/2010", "dd/MM/yyyy", new CultureInfo("pt-BR")),
                "2136229365", "21991467842", "albertftw@gmail.com", "9952432", "MARCELO KAIQUE", "SARA SOPHIA");

            Professor p1 = new Professor("GABRIEL ENZO", "07273739782", "43.975.996-1",
                DateTime.ParseExact("09/04/1989", "dd/MM/yyyy", new CultureInfo("pt-BR")),
                "2237095317", "22989187620", "gabrielprof@gmail.com");
            Professor p2 = new Professor("MATHEUS DA ROCHA", "96517311769", "42.464.823-4",
                DateTime.ParseExact("09/06/1978", "dd/MM/yyyy", new CultureInfo("pt-BR")),
                "2437286239", "24984621420", "mathprof@gmail.com");
            Professor p3 = new Professor("MURILO ANTONIO", "92599362768", "22.315.780-6",
                DateTime.ParseExact("02/04/1965", "dd/MM/yyyy", new CultureInfo("pt-BR")),
                "2125945504", "21983584802", "murillgamer@gmail.com");

            Turma t1 = new Turma("03A3N", "7° ANO");
            Turma t2 = new Turma("01A4N", "8° ANO");
            Turma t3 = new Turma("08A1N", "9° ANO");

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
