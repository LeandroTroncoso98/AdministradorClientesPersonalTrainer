using Abstraccion;
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
    public class MPPRutina : IAdministrable<Rutina>
    {
        private AccesoParametro _accprm;
        private ArrayList _al;

        public bool Actualizar(Rutina t)
        {
            try
            {
                string query = "SpRutina_Actualizar";
                _accprm = new AccesoParametro();
                _al = new ArrayList();
                SqlParameter prm1 = new SqlParameter("@Objetivo", SqlDbType.NVarChar);
                prm1.Value = t.Objetivo;
                _al.Add(prm1);
                SqlParameter prm2 = new SqlParameter("@Cliente_Id", SqlDbType.Int);
                prm2.Value = t.Cliente.Id;
                _al.Add(prm2);
                return _accprm.Escribir(query, _al);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Agregar(Rutina t)
        {
            try
            {
                string query = "SpRutina_Crear";
                _accprm = new AccesoParametro();
                _al = new ArrayList();
                SqlParameter prm1 = new SqlParameter("@Cliente_Id", SqlDbType.Int);
                prm1.Value = t.Cliente.Id;
                _al.Add(prm1);
                SqlParameter prm2 = new SqlParameter("@Objetivo", SqlDbType.NVarChar);
                prm2.Value = t.Objetivo;
                _al.Add(prm2);
                return _accprm.Escribir(query, _al);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Borrar(int clienteId)
        {
            try
            {
                string query = "SpRutina_Borrar";
                _accprm = new AccesoParametro();
                _al = new ArrayList();
                SqlParameter prm1 = new SqlParameter("@Cliente_Id", SqlDbType.Int);
                prm1.Value = clienteId;
                _al.Add(prm1);
                return _accprm.Escribir(query, _al);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public Rutina LeerRutina(int clienteId)
        {
            try
            {
                string query = "SpRutina_Leer";
                _accprm = new AccesoParametro();
                _al = new ArrayList();

                SqlParameter prm1 = new SqlParameter("@Cliente_Id", SqlDbType.Int);
                prm1.Value = clienteId;
                _al.Add(prm1);
                DataTable table = _accprm.leer(query, _al);
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    Rutina rutina = new Rutina();
                    rutina.Id = Convert.ToInt32(row[0]);
                    rutina.Objetivo = row[1].ToString();
                    return rutina;
                }
                return null;
            }catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
