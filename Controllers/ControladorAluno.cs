using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Parsers;

namespace SistemaEscola.Controllers
{
    class ControladorAluno : IController<Aluno>
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void Add(FormularioAluno form)
        {
            // Checks if Aluno already exists
            if (FindAll().Any(d => d.Cpf == form.Cpf || d.Matricula == form.Matricula ||
                d.Email == form.Email))
            {
                throw new Exception("Aluno já cadastrado");
            }

            // Adds new Aluno in Db
            var aluno = new Aluno(form.Id, form.Nome, CpfParse.ToNumber(form.Cpf), RgParse.ToNumber(form.Rg),
                form.DataNascimento, PhoneNumberParse.ToNumber(form.TelefoneResidencial),
                PhoneNumberParse.ToNumber(form.TelefoneCelular),
                form.Email, form.Matricula, form.NomePai, form.NomeMae, form.NomeResponsavel);

            _context.Alunos.Add(aluno);
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

                _context.Alunos.Add(new Aluno(form.Id, form.Nome, form.Cpf, form.Rg,
                form.DataNascimento, form.TelefoneResidencial, form.TelefoneCelular,
                form.Email, form.Matricula, form.NomePai, form.NomeMae, form.NomeResponsavel));
            }
        }

        public List<Aluno> FindAll()
        {
            return _context.Alunos;
        }

        public Aluno FindById(int Id)
        {
            return _context.Alunos.Find(x => x.Id == Id);
        }

        public Aluno FindByName(string name)
        {
            return _context.Alunos.Find(x => x.Nome == name);
        }
    }
}
