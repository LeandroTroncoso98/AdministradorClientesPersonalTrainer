using BE;
using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapper
{
    public class MPPCliente
    {
        private AccesoParametro _accParametro;
        private ArrayList _al;

        public List<Cliente> Listar()
        {
            try
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
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool ExisteEmail(string email,int idException = 0)
        {
            try
            {
                _accParametro = new AccesoParametro();
                _al = new ArrayList();
                string query = "SpCliente_EmailExiste";
                SqlParameter prm1 = new SqlParameter("@Id", SqlDbType.Int);
                prm1.Value = idException;
                _al.Add(prm1);
                DataTable table = _accParametro.leer(query, _al);
                if (table.Rows.Count > 0)
                {
                    List<Cliente> clientes = new List<Cliente>();
                    foreach(DataRow row in table.Rows)
                    {
                        Cliente nCliente = new Cliente();
                        nCliente.Id = Convert.ToInt32(row[0]);
                        nCliente.Email = row[1].ToString();
                        clientes.Add(nCliente);
                    }
                    return clientes.Any(m => m.Email.Trim().ToLower() == email.Trim().ToLower());
                }
                else return false;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Agregar(Cliente nCliente)
        {
            try
            {
                string query = "SpCliente_Crear";
                _accParametro = new AccesoParametro();
                _al = new ArrayList();
                SqlParameter prm1 = new SqlParameter("@Nombre", SqlDbType.NChar);
                prm1.Value = nCliente.Nombre;
                _al.Add(prm1);
                SqlParameter prm2 = new SqlParameter("@Apellido", SqlDbType.NChar);
                prm2.Value = nCliente.Apellido;
                _al.Add(prm2);
                SqlParameter prm3 = new SqlParameter("@Email", SqlDbType.NVarChar);
                prm3.Value = nCliente.Email;
                _al.Add(prm3);
                SqlParameter prm4 = new SqlParameter("@Numero", SqlDbType.NChar);
                prm4.Value = nCliente.TelefonoNum;
                _al.Add(prm4);
                return _accParametro.Escribir(query, _al);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Actualizar(Cliente aCliente)
        {
            try
            {
                string query = "SpCliente_Actualizar";
                _accParametro = new AccesoParametro();
                _al = new ArrayList();
                SqlParameter prm1 = new SqlParameter("@Id", SqlDbType.Int);
                prm1.Value = aCliente.Id;
                _al.Add(prm1);
                SqlParameter prm2 = new SqlParameter("@Nombre", SqlDbType.NChar);
                prm2.Value = aCliente.Nombre;
                _al.Add(prm2);
                SqlParameter prm3 = new SqlParameter("@Apellido", SqlDbType.NChar);
                prm3.Value = aCliente.Apellido;
                _al.Add(prm3);
                SqlParameter prm4 = new SqlParameter("@Numero", SqlDbType.NChar);
                prm4.Value = aCliente.TelefonoNum;
                _al.Add(prm4);
                SqlParameter prm5 = new SqlParameter("@Email", SqlDbType.NVarChar);
                prm5.Value = aCliente.Email;
                _al.Add(prm5);
                return _accParametro.Escribir(query, _al);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Borrar(int id)
        {
            try
            {
                string query = "SpCliente_Borrar";
                _accParametro = new AccesoParametro();
                _al = new ArrayList();
                SqlParameter prm1 = new SqlParameter("@Id", SqlDbType.Int);
                prm1.Value = id;
                _al.Add(prm1);
                return _accParametro.Escribir(query, _al);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
