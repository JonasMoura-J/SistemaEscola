using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Data;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorTurma : IController<Turma>
    {
        private readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

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

            form.Alunos.ForEach(a => alunosToInsert.Add(_controladorAluno.FindByName(a)));
            _context.Alunos.AttachRange(alunosToInsert);

            form.Disciplinas.ForEach(d => disciplinasToInsert.Add(_controladorDisciplina.FindByName(d)));
            _context.Disciplinas.AttachRange(disciplinasToInsert);

            // Adds new Turma to Db
            var turma = new Turma(form.Codigo, form.Nome,
                form.QuantidadeAlunos);

            turma.InsertAlunos(alunosToInsert);
            turma.InsertDisciplinas(disciplinasToInsert);

            _context.Turmas.Add(turma);

            _context.SaveChanges();

            // Updates Aluno with new data
            alunosToInsert.ForEach(a => a.UpdateTurma(turma));
            alunosToInsert.ForEach(a => disciplinasToInsert.ForEach(d => a.AddDisciplina(d)));

            alunosToInsert.ForEach(a => _controladorAluno.Update(a));
            //_context.Alunos.UpdateRange(alunosToInsert);

            //_context.SaveChanges();
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

        public List<Turma> FindAll()
        {
            return _context.Turmas.ToList();
        }

        public Turma FindById(int id)
        {
            var turma = _context.Turmas.Where(t => t.Id == id);

            if (!turma.Any())
            {
                return null;
            }

            return turma.First();
        }

        public Turma FindByName(string name)
        {
            var turma = _context.Turmas.Where(t => t.Nome == name);

            if (!turma.Any())
            {
                return null;
            }

            return turma.First();
        }
    }
}
