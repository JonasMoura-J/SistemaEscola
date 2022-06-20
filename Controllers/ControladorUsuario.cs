using System;
using System.Linq;
using System.Collections.Generic;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Entities;
using SistemaEscola.Data;

namespace SistemaEscola.Controllers
{
    class ControladorUsuario : IController<Usuario>
    {
        readonly SistemaEscolaDbContext _context = new SistemaEscolaDbContext();

        public static readonly ControladorUsuario Instance = new ControladorUsuario();

        public void Add(FormularioUsuario form)
        {
            // Check if already exists
            if (FindAll().Any(u => u.Nome == form.Nome))
            {
                throw new Exception("Usuário já cadastrado");
            }

            // Adds new Usuario to Db
            var usuario = new Usuario(form.Nome.ToUpper(), form.Senha);

            _context.Usuarios.Add(usuario);

            _context.SaveChanges();
        }

        public List<Usuario> FindAll()
        {
            return _context.Usuarios.OrderBy(u => u.Nome).ToList();
        }

        public Usuario FindByName(string name)
        {
            var user = _context.Usuarios.Where(u => u.Nome == name);

            if (!user.Any())
            {
                return null;
            }

            return user.First();
        }

        public bool ConfirmLogin(FormularioUsuario form)
        {
            var user = FindByName(form.Nome);

            if (user == null)
            {
                throw new Exception("Usuário não cadastrado.");
            }

            if (form.Senha != user.Senha)
            {
                throw new Exception("Senha incorreta.");
            }

            return true;
        }
    }
}
