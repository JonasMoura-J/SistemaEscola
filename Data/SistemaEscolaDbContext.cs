using Microsoft.EntityFrameworkCore;
using System;
using SistemaEscola.Entities;
using SistemaEscola.Entities.JoinClasses;
using System.IO;
using System.Configuration;

namespace SistemaEscola.Data
{
    class SistemaEscolaDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ProfessorDisciplina> ProfessorDisciplinas { get; set; }

        public string DbPath { get; }

        public SistemaEscolaDbContext()
        {
            DbPath = @"Data\Database\SistemaEscola.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlite($"Data Source={DbPath}");
            //options.UseSqlite($@"Data Source={Directory.GetParent(Environment.CurrentDirectory).Parent.FullName}\Data\Database\SistemaEscola.db");
            //options.UseMySql(ConfigurationManager.ConnectionStrings["DbLocation"].ConnectionString);
            //options.UseSqlite($@"Data Source=d:\trabalhos\uni\5th p\es\schoolapp v1.1\sistemaescola\data\database\SistemaEscola.db");
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SistemaEscola.db;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfessorDisciplina>().HasKey(x => new { x.ProfessorId, x.DisciplinaId });

            modelBuilder.Entity<ProfessorDisciplina>()
                .HasOne(pd => pd.Professor)
                .WithMany(p => p.ProfessorDisciplinas)
                .HasForeignKey(pd => pd.ProfessorId);

            modelBuilder.Entity<ProfessorDisciplina>()
                .HasOne(pd => pd.Disciplina)
                .WithMany(d => d.ProfessorDisciplinas)
                .HasForeignKey(pd => pd.DisciplinaId);

            modelBuilder.Entity<Turma>()
                .HasMany(t => t.Alunos)
                .WithOne(a => a.Turma);
        }
    }
}
