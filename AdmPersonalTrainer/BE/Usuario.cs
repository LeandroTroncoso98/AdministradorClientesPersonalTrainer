using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Usuario : IIdentity
    {
        public int Id{ get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TelefonoNum { get; set; }
        public string Email { get; set; }

    }
}
