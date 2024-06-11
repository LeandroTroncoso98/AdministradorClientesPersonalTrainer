using BE;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class BLLDia
    {
        public BLLDia()
        {
            _mpp = new MPPDia();
        }
        MPPDia _mpp;
        public List<Dia> Listar()
        {
            return _mpp.Listar();
        }
    }
}
