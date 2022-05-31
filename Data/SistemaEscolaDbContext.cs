using Microsoft.EntityFrameworkCore;
using SistemaEscola.Entities;
using SistemaEscola.Entities.JoinClasses;

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
        public DbSet<AlunoFaltaDisciplina> AlunoFaltaDisciplinas { get; set; }
        public DbSet<TurmaDisciplina> TurmaDisciplinas { get; set; }
        public DbSet<TurmaProfessor> TurmaProfessores { get; set; }

        public string DbPath { get; }

        public SistemaEscolaDbContext()
        {
            DbPath = @"Data\Database\SistemaEscola.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SistemaEscola.db;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aluno _1______n_ AlunoFaltaDisciplina _n______1_ Disciplina
            modelBuilder.Entity<AlunoFaltaDisciplina>().HasKey(x => new { x.AlunoId, x.DisciplinaId });

            modelBuilder.Entity<AlunoFaltaDisciplina>()
                .HasOne(afd => afd.Aluno)
                .WithMany(a => a.AlunoFaltaDisciplinas)
                .HasForeignKey(afd => afd.AlunoId);

            modelBuilder.Entity<AlunoFaltaDisciplina>()
                .HasOne(afd => afd.Disciplina)
                .WithMany(d => d.AlunoFaltaDisciplinas)
                .HasForeignKey(afd => afd.DisciplinaId);

            // Professor _1______n_ ProfessorDisciplina _n______1_ Disciplina
            modelBuilder.Entity<ProfessorDisciplina>().HasKey(x => new { x.ProfessorId, x.DisciplinaId });

            modelBuilder.Entity<ProfessorDisciplina>()
                .HasOne(pd => pd.Professor)
                .WithMany(p => p.ProfessorDisciplinas)
                .HasForeignKey(pd => pd.ProfessorId);

            modelBuilder.Entity<ProfessorDisciplina>()
                .HasOne(pd => pd.Disciplina)
                .WithMany(d => d.ProfessorDisciplinas)
                .HasForeignKey(pd => pd.DisciplinaId);

            // Turma _1______n_ TurmaDisciplina _n______1_ Disciplina
            modelBuilder.Entity<TurmaDisciplina>().HasKey(x => new { x.TurmaId, x.DisciplinaId });

            modelBuilder.Entity<TurmaDisciplina>()
                .HasOne(td => td.Turma)
                .WithMany(t => t.TurmaDisciplinas)
                .HasForeignKey(td => td.TurmaId);

            modelBuilder.Entity<TurmaDisciplina>()
                .HasOne(td => td.Disciplina)
                .WithMany(d => d.TurmaDisciplinas)
                .HasForeignKey(td => td.DisciplinaId);

            // Turma _1______n_ TurmaProfessor _n______1_ Professor
            modelBuilder.Entity<TurmaProfessor>().HasKey(x => new { x.TurmaId, x.ProfessorId });

            modelBuilder.Entity<TurmaProfessor>()
                .HasOne(tp => tp.Turma)
                .WithMany(t => t.TurmaProfessores)
                .HasForeignKey(tp => tp.TurmaId);

            modelBuilder.Entity<TurmaProfessor>()
                .HasOne(tp => tp.Professor)
                .WithMany(p => p.TurmaProfessores)
                .HasForeignKey(tp => tp.ProfessorId);

            // Turma _1______n_ Aluno
            modelBuilder.Entity<Turma>()
                .HasMany(t => t.Alunos)
                .WithOne(a => a.Turma)
                .HasForeignKey(a => a.TurmaId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
