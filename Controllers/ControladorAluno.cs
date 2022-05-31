﻿using System;
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
            var aluno = new Aluno(form.Nome, CpfParse.ToNumber(form.Cpf), RgParse.ToNumber(form.Rg),
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

        public void Delete(int id)
        {
            Aluno aluno = FindById(id);

            if (aluno != null) {
                _context.Alunos.Remove(aluno);
            }

            _context.SaveChanges();
        }

        public void Update(FormularioAluno form)
        {
            /*
            Aluno aluno = FindById(form.Id);

            if (aluno != null) {

                aluno.UpdateTurma(form.t)

                _context.Alunos.Update(aluno);
                _context.SaveChanges();
            }
            */
        }

        public void Update(Aluno aluno)
        {
            if (aluno != null)
            {
                var a = FindById(aluno.Id);
                
                _context.Alunos.Update(a);
                _context.SaveChanges();
            }
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

        public void AddFaltas(string nomeAluno, Disciplina disciplina, int faltas = 1)
        {
            var aluno = FindByName(nomeAluno);

            aluno.AddFaltas(disciplina, faltas);
        }
    }
}
