using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente : Usuario
    {
        public Cuenta Cuenta { get; set; }
        public Rutina Rutina { get; set; }
    }
}
