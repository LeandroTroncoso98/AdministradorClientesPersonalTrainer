using Abstraccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Rutina : IIdentity
    {
        public int Id { get; set; }
        public string  Objetivo { get; set; }
        public List<Dia> Dias { get; set; }
    }
}
