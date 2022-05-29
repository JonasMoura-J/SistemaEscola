﻿using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Data;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Parsers;

namespace SistemaEscola.Controllers
{
    class ControladorAluno : IController<Aluno>
    {
        private readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

        public void Add(FormularioAluno form)
        {
            // Checks if Aluno already exists
            if (FindAll().Any(a => a.Cpf == form.Cpf || a.Matricula == form.Matricula ||
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

        public void Delete(int Id)
        {
            Aluno aluno = FindById(Id);

            if (aluno != null) {
                _context.Alunos.Remove(FindById(Id));
            }
        }

        public void Update(FormularioAluno form)
        {
            Aluno aluno = FindById(form.Id);

            if (aluno != null) {
                _context.Alunos.Remove(aluno);

                _context.Alunos.Add(new Aluno(form.Nome, form.Cpf, form.Rg,
                form.DataNascimento, form.TelefoneResidencial, form.TelefoneCelular,
                form.Email, form.Matricula, form.NomePai, form.NomeMae, form.NomeResponsavel));
            }
        }

        public List<Aluno> FindAll()
        {
            return _context.Alunos.ToList();
        }

        public Aluno FindById(int id)
        {
            var aluno = _context.Alunos.Where(a => a.Id == id);

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

        public void AddFaltas(string nomeAluno, Disciplina disciplina, int faltas = 1)
        {
            var aluno = FindByName(nomeAluno);

            aluno.AddFaltas(disciplina, faltas);
        }
    }
}
