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
        public List<Cliente> Listar()
        {
            return oMPPCliente.Listar();
        }
        public bool Agregar(Cliente cliente)
        {
            return oMPPCliente.Agregar(cliente);
        }
        public bool Actualizar(Cliente cliente)
        {
            return oMPPCliente.Actualizar(cliente);
        }
        public bool ExisteEmail(string email, int idException = 0)
        {
            return oMPPCliente.ExisteEmail(email, idException);
        }
        public bool Borrar(int id)
        {
            return oMPPCliente.Borrar(id);
        }
    }
}
