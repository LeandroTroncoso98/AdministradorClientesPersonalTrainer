using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion
{
    public interface IAdministrable<T>
    {
        bool Agregar(T t);
        bool Actualizar(T t);
        bool Borrar(int id);
    }
}
