using System;
using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorUsuario : IController<Usuario>
    {
        private readonly TempDb _context = TempDb.Instanse;

        public bool ConfirmLogin(FormularioUsuario form)
        {
            var user = FindByName(form.Nome);

            if (user != null)
            {
                if (form.Senha == user.Senha)
                {
                    return true;
                }
            }

            return false;
        }

        public void Add(FormularioUsuario form)
        {
            // Check if already exists
            if (FindAll().Any(u => u.Nome == form.Nome))
            {
                throw new Exception("Usuário já cadastrado");
            }

            // Adds new Usuario to Db
            var usuario = new Usuario(FindAll().Count + 1, form.Nome, form.Senha);

            _context.Usuarios.Add(usuario);
        }

        public List<Usuario> FindAll()
        {
            return _context.Usuarios;
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
    }
}
