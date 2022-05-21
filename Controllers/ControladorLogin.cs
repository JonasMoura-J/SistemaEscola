using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorLogin : IController<Usuario>
    {
        private readonly TempDb _context = TempDb.Instanse;

        public bool ConfirmLogin(FormularioLogin form)
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
