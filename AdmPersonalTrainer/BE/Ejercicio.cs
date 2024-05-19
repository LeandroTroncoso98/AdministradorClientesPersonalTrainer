using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Ejercicio : IIdentity
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string LinkVideo { get; set; }
    }
}
