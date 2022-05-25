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
        private readonly ControladorDisciplina _controladorDisciplina = new ControladorDisciplina();

        public void Add(FormularioTurma form)
        {
            // Check if already exists
            if (FindAll().Any(d => d.Nome == form.Nome || d.Codigo == form.Codigo))
            {
                throw new Exception("Turma já cadastrada");
            }

            // Prepares the lists of Disciplinas and Alunos
            var alunosToInsert = new List<Aluno>();
            var disciplinasToInsert = new List<Disciplina>();

            foreach (string aluno in form.Alunos)
            {
                alunosToInsert.Add(_controladorAluno.FindByName(aluno));
            }

            foreach (string disc in form.Disciplinas)
            {
                disciplinasToInsert.Add(_controladorDisciplina.FindByName(disc));
            }

            // Adds new Turma to Db
            var turma = new Turma(form.Id, form.Codigo, form.Nome,
                form.QuantidadeAlunos, alunosToInsert, disciplinasToInsert);

            _context.Turmas.Add(turma);

            // Updates Aluno with new data
            alunosToInsert.ForEach(a => a.UpdateTurma(turma));
            alunosToInsert.ForEach(a => disciplinasToInsert.ForEach(d => a.AddDisciplina(d)));
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
