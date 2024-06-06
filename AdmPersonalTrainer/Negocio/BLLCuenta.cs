using BE;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class BLLCuenta
    {
        private MPPCuenta _MPPCuenta;
        public BLLCuenta()
        {
            _MPPCuenta = new MPPCuenta();
        }
        public Cuenta LeerCuenta(int idCliente)
        {
            return _MPPCuenta.LeerCuenta(idCliente);
        }
        public bool Actualizar(Cuenta aCuenta)
        {
            return _MPPCuenta.Actualizar(aCuenta);
        }
        public bool Agregar(Cuenta nCuenta)
        {
            return _MPPCuenta.Agregar(nCuenta);
        }
        public bool Borrar(int usuario_Id)
        {
            return _MPPCuenta.Borrar(usuario_Id);
        }
    }
}
