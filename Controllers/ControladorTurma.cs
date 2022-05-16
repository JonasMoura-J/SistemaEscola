﻿using System.Collections.Generic;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorTurma
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void Add(FormularioTurma form)
        {
            _context.Turmas.Add(new Turma(form.Id, form.Codigo, form.Nome, form.QuantidadeAlunos));
        }
        public List<Turma> FindAll()
        {
            return _context.Turmas;
        }

        public void Delete(int Id)
        {
            Turma turma = Find(Id);

            if (turma != null) {
                _context.Turmas.Remove(turma);
            }

        }

        public void Update(FormularioTurma form)
        {
            Turma turma = Find(form.Id);

            if (turma != null) {

                _context.Turmas.Remove(turma);
                _context.Turmas.Add(new Turma(form.Id, form.Codigo, form.Nome, form.QuantidadeAlunos));
            }
        }

        public Turma Find(int Id)
        {
            return _context.Turmas.Find(x => x.Id == Id);
        }
    }
}