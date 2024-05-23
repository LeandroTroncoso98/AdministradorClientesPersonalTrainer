using BE;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class BLLCliente
    {
        public BLLCliente()
        {
            oMPPCliente = new MPPCliente();
        }
        MPPCliente oMPPCliente;
        public List<Cliente> ListarClientes()
        {
            return oMPPCliente.ListarClientes();
        }
    }
}
