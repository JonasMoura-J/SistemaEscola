using System;
using System.Linq;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Entities.JoinClasses;
using SistemaEscola.Entities;
using SistemaEscola.Parsers;
using SistemaEscola.Data;

namespace SistemaEscola.Controllers
{
    class ControladorAluno : IController<Aluno>
    {
        readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

        public static readonly ControladorAluno Instance = new ControladorAluno();

        public void Add(FormularioAluno form)
        {
            // Checks if Aluno already exists
            if (FindAll().Any(a => CpfParse.ToDigit(a.Cpf) == form.Cpf || a.Matricula == form.Matricula ||
                a.Email == form.Email))
            {
                throw new Exception("Aluno já cadastrado");
            }

            // Adds new Aluno in Db
            var aluno = new Aluno(form.Nome, CpfParse.ToNumber(form.Cpf), form.Rg,
                form.DataNascimento, PhoneNumberParse.ToNumber(form.TelefoneResidencial),
                PhoneNumberParse.ToNumber(form.TelefoneCelular),
                form.Email, form.Matricula, form.NomePai, form.NomeMae, form.NomeResponsavel);

            _context.Alunos.Add(aluno);

            _context.SaveChanges();
        }

        public List<Aluno> FindAll()
        {
            return _context.Alunos.OrderBy(a => a.Nome).ToList();
        }

        public Aluno FindById(int id)
        {
            var aluno = _context.Alunos.Find(id);

            if (aluno == null)
            {
                return null;
            }

            return aluno;
        }

        public Aluno FindByCpf(string cpf)
        {
            var aluno = _context.Alunos.Where(a => a.Cpf == CpfParse.ToNumber(cpf));

            if (!aluno.Any())
            {
                return null;
            }

            return aluno.First();
        }

        public Aluno FindByName(string name)
        {
            var aluno = _context.Alunos.Where(a => a.Nome == name);

            if (!aluno.Any())
            {
                return null;
            }

            return aluno.First();
        }

        public void Update(FormularioAluno form)
        {
            Aluno aluno = FindById(form.Id);

            if (aluno != null)
            {
                // Updates Aluno
                aluno.Nome = form.Nome;
                aluno.Cpf = CpfParse.ToNumber(form.Cpf);
                aluno.Rg = form.Rg;
                aluno.DataNascimento = form.DataNascimento;
                aluno.TelefoneResidencial = PhoneNumberParse.ToNumber(form.TelefoneResidencial);
                aluno.TelefoneCelular = PhoneNumberParse.ToNumber(form.TelefoneCelular);
                aluno.Email = form.Email;
                aluno.NomePai = form.NomePai;
                aluno.NomeMae = form.NomeMae;
                aluno.NomeResponsavel = form.NomeResponsavel;
                aluno.Matricula = form.Matricula;
                aluno.TurmaId = form.TurmaId;

                // Updates disciplinas
                UpdateFaltaDisciplinas(form);

                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Aluno aluno = FindById(id);

            if (aluno != null) {
                _context.Alunos.Remove(aluno);
            }

            _context.SaveChanges();
        }

        public void AddFaltaDisciplina(int alunoId, int disciplinaId)
        {
            if (!_context.AlunoFaltaDisciplinas.Any(afd => afd.AlunoId == alunoId &&
            afd.DisciplinaId == disciplinaId))
            {
                _context.AlunoFaltaDisciplinas.Add(new AlunoFaltaDisciplina()
                {
                    AlunoId = alunoId,
                    DisciplinaId = disciplinaId,
                });
            }
        }

        public void RemoveFaltaDisciplina(int alunoId, int disciplinaId)
        {
            var afd = _context.AlunoFaltaDisciplinas.Find(alunoId, disciplinaId);

            if (afd != null)
            {
                _context.AlunoFaltaDisciplinas.Remove(afd);
            }
        }
        
        public void UpdateFaltaDisciplinas(FormularioAluno form, bool saveChanges = false)
        {
            var alunoId = form.Id;

            if (alunoId == 0)
            {
                alunoId = FindByCpf(form.Cpf).Id;
            }

            var alunoFaltaDisciplinas = FindAllAlunoFaltaDisciplinasByAluno(alunoId);

            foreach (var fd in form.FormularioDisciplinas)
            {
                if (!alunoFaltaDisciplinas.Any(afd => afd.DisciplinaId == fd.Id))
                {
                    AddFaltaDisciplina(alunoId, fd.Id);
                }
            }

            foreach (var afd in alunoFaltaDisciplinas)
            {
                if (!form.FormularioDisciplinas.Any(fd => fd.Id == afd.DisciplinaId))
                {
                    RemoveFaltaDisciplina(afd.AlunoId, afd.DisciplinaId);
                }
            }

            if (saveChanges)
            {
                _context.SaveChanges();
            }
        }

        public void AddFaltas(string nomeAluno, Disciplina disciplina, int faltas = 1)
        {
            var aluno = FindByName(nomeAluno);

            aluno.AddFaltas(disciplina, faltas);
        }

        public List<AlunoFaltaDisciplina> FindAllAlunoFaltaDisciplinasByAluno(int alunoId)
        {
            return _context.AlunoFaltaDisciplinas.Where(afd => afd.AlunoId == alunoId).ToList();
        }
        
        public void UpdateTurma(int alunoId, int turmaId, bool saveChanges = false)
        {
            var aluno = FindById(alunoId);

            if (aluno != null)
            {
                aluno.TurmaId = turmaId;

                if (saveChanges)
                {
                    _context.SaveChanges();
                }
            }
        }
    }
}
