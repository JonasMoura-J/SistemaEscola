using System.Collections.Generic;
using System.Linq;
using SistemaEscola.Db;
using SistemaEscola.Entities;
using SistemaEscola.Entities.Formularios;

namespace SistemaEscola.Controllers
{
    class ControladorLogin
    {
        private readonly TempDb _context = TempDb.Instanse;

        public bool ConfirmLogin(FormularioLogin form)
        {
            var users = FindAll();

            if (FindAll().Any(u => u.Nome == form.Nome))
            {
                if (form.Senha == users.Where(u => u.Nome == form.Nome).ToList()[0].Senha)
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
    }
}
