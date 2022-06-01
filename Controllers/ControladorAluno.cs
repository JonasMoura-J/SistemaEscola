using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Data;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Entities.JoinClasses;
using SistemaEscola.Parsers;

namespace SistemaEscola.Controllers
{
    class ControladorAluno : IController<Aluno>
    {
        private readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

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
                var alunoFaltaDisciplinas = FindAllAlunoFaltaDisciplinaByAluno(aluno.Id);

                foreach (var fd in form.FormularioDisciplinas)
                {
                    if (!alunoFaltaDisciplinas.Any(afd => afd.DisciplinaId == fd.Id))
                    {
                        AddFaltaDisciplina(aluno.Id, fd.Id, true);
                    }
                }

                foreach (var afd in alunoFaltaDisciplinas)
                {
                    if (!form.FormularioDisciplinas.Any(fd => fd.Id == afd.DisciplinaId))
                    {
                        RemoveFaltaDisciplina(afd.AlunoId, afd.DisciplinaId, true);
                    }
                }

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

        public void AddFaltaDisciplina(int alunoId, int disciplinaId, bool isBugged = false)
        {
            if (!_context.AlunoFaltaDisciplinas.Any(afd => afd.AlunoId == alunoId &&
            afd.DisciplinaId == disciplinaId))
            {
                _context.AlunoFaltaDisciplinas.Add(new AlunoFaltaDisciplina()
                {
                    AlunoId = alunoId,
                    DisciplinaId = disciplinaId,
                });

                if (!isBugged)
                {
                    _context.SaveChanges();
                }
            }
        }

        public void RemoveFaltaDisciplina(int alunoId, int disciplinaId, bool isBugged = false)
        {
            var afd = _context.AlunoFaltaDisciplinas.Find(alunoId, disciplinaId);

            if (afd != null)
            {
                _context.AlunoFaltaDisciplinas.Remove(afd);

                if (!isBugged)
                {
                    _context.SaveChanges();
                }
            }
        }

        public void AddFaltas(string nomeAluno, Disciplina disciplina, int faltas = 1)
        {
            var aluno = FindByName(nomeAluno);

            aluno.AddFaltas(disciplina, faltas);
        }

        public List<AlunoFaltaDisciplina> FindAllAlunoFaltaDisciplinaByAluno(int alunoId)
        {
            return _context.AlunoFaltaDisciplinas.Where(afd => afd.AlunoId == alunoId).ToList();
        }
    }
}
