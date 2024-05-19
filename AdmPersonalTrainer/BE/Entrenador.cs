using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Entrenador
    {
        public string Contraseña { get; set; }
        public int Suscritos { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
