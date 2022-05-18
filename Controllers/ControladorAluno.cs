using System.Collections.Generic;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorAluno
    {
        private readonly TempDb _context = TempDb.Instanse;

        public void Add(FormularioAluno form)
        {
            _context.Alunos.Add(new Aluno(form.Id, form.Nome, form.Cpf, form.Rg,
                form.DataNascimento, form.TelefoneResidencial, form.TelefoneCelular,
                form.Email, form.Matricula, form.NomePai, form.NomeMae, form.NomeResponsavel));
        }

        public void Delete(int Id)
        {
            Aluno aluno = Find(Id);

            if (aluno != null) {
                _context.Alunos.Remove(Find(Id));
            }
        }

        public void Update(FormularioAluno form)
        {
            Aluno aluno = Find(form.Id);

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

        public Aluno Find(int Id)
        {
            return _context.Alunos.Find(x => x.Id == Id);
        }
    }
}
