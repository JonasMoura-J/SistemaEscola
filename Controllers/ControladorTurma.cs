using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorTurma : IController<Turma>
    {
        private readonly TempDb _context = TempDb.Instanse;
        private readonly ControladorAluno _controladorAluno = new ControladorAluno();

        public void Add(FormularioTurma form)
        {
            if (FindAll().Any(d => d.Nome == form.Nome || d.Codigo == form.Codigo))
            {
                throw new Exception("Turma já cadastrada");
            }

            var alunosToInsert = new List<Aluno>();

            foreach (string aluno in form.Alunos)
            {
                alunosToInsert.Add(_controladorAluno.FindByName(aluno));
            }

            _context.Turmas.Add(new Turma(form.Id, form.Codigo, form.Nome,
                form.QuantidadeAlunos, alunosToInsert));
        }
        public List<Turma> FindAll()
        {
            return _context.Turmas;
        }

        public void Delete(int Id)
        {
            Turma turma = FindById(Id);

            if (turma != null) {
                _context.Turmas.Remove(turma);
            }
        }

        // Not working for now
        public void Update(FormularioTurma form)
        {
            Turma turma = FindById(form.Id);

            if (turma != null) {

                _context.Turmas.Remove(turma);
                //_context.Turmas.Add(new Turma(form.Id, form.Codigo, form.Nome, form.QuantidadeAlunos, ));
            }
        }

        public Turma FindById(int Id)
        {
            return _context.Turmas.Find(x => x.Id == Id);
        }
    }
}
