using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente : Usuario
    {
        public string Objetivo { get; set; }
        public Cuenta Cuenta { get; set; }
        public List<Ejercicio> Ejercicios { get; set; }
    }
}
