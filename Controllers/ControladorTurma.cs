using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Data;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Entities.JoinClasses;

namespace SistemaEscola.Controllers
{
    class ControladorTurma : IController<Turma>
    {
        private readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

        private readonly ControladorAluno _controladorAluno = ControladorAluno.Instance;
        private readonly ControladorDisciplina _controladorDisciplina = new ControladorDisciplina();

        public static readonly ControladorTurma Instance = new ControladorTurma();

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

            alunosToInsert.ForEach(a => turma.InsertAluno(a));
            turma.InsertDisciplinas(disciplinasToInsert);

            _context.Turmas.Add(turma);

            // Updates Aluno with new data
            alunosToInsert.ForEach(a => disciplinasToInsert.ForEach(
                d => _controladorAluno.AddFaltaDisciplina(a.Id, d.Id, true)));

            _context.SaveChanges();
        }

        public List<Turma> FindAll()
        {
            return _context.Turmas.OrderBy(t => t.Nome).ToList();
        }

        public Turma FindById(int id)
        {
            var turma = _context.Turmas.Find(id);

            if (turma == null)
            {
                return null;
            }

            return turma;
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

        public void Delete(int Id)
        {
            Turma turma = FindById(Id);

            if (turma != null) {
                _context.Turmas.Remove(turma);
            }

            _context.SaveChanges();
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

        public List<TurmaDisciplina> FindAllTurmaDisciplinaByDisciplina(int disciplinaId)
        {
            return _context.TurmaDisciplinas.Where(td => td.DisciplinaId == disciplinaId).ToList();
        }
    }
}
