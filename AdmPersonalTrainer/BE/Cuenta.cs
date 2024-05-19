using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cuenta : IIdentity 
    {
        public int Id { get; set; }
        public EnumEstado Estado { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public decimal Monto { get; set; }
    }
}
