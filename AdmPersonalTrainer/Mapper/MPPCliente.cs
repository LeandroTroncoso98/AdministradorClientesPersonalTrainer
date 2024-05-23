using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MPPCliente
    {
        private AccesoParametro _accParametro;
        private ArrayList _al;

        public List<Cliente> ListarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            _accParametro = new AccesoParametro();
            string query = "SpCliente_Listar";
            DataTable table;
            table = _accParametro.leer(query, null);
            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(row[0]);
                    cliente.Nombre = row[1].ToString().Trim();
                    cliente.Apellido = row[2].ToString().Trim();
                    cliente.Email = row[3].ToString().Trim();
                    cliente.TelefonoNum = row[4].ToString().Trim();
                    clientes.Add(cliente);
                }
                return clientes;
            }
            else
                return clientes = null;
        }
    }
}
