using System.Collections.Generic;

namespace SistemaEscola.Controllers
{
    interface IController<T>
    {
        List<T> FindAll();
    }
}
