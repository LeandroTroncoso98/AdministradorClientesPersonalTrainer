using BE;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class BLLRutina
    {
        public BLLRutina()
        {
            _mpp = new MPPRutina();
        }
        private MPPRutina _mpp;
        public Rutina LeerRutina(int clienteId)
        {
            return _mpp.LeerRutina(clienteId);
        }
        public bool Actualizar(Rutina rutina)
        {
            return _mpp.Actualizar(rutina);
        }
        public bool Agregar(Rutina rutina)
        {
            return _mpp.Agregar(rutina);
        }
        public bool Borrar(int clienteId)
        {
            return _mpp.Borrar(clienteId);
        }
    }
}
