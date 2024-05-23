using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccesoParametro
    {
        private SqlConnection oCnn = new SqlConnection(@"Data Source=DESKTOP-KB5GB1U\SQLEXPRESS01;Initial Catalog=ADMPT;Integrated Security=True");
        private SqlCommand cmd;
        private SqlTransaction Trx;
        public DataTable leer(string consulta, ArrayList parametros)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            cmd = new SqlCommand(consulta, oCnn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                da = new SqlDataAdapter(cmd);
                if (parametros != null)
                {
                    foreach (SqlParameter data in parametros)
                    {
                        cmd.Parameters.AddWithValue(data.ParameterName, data.Value);
                    }
                }
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }

        }
        public bool LeerScalar(string consulta, ArrayList parametros)
        {
            oCnn.Open();
            cmd = new SqlCommand(consulta, oCnn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                if (parametros != null)
                {
                    foreach (SqlParameter data in parametros)
                    {
                        cmd.Parameters.AddWithValue(data.ParameterName, data.Value);
                    }
                }
                int respuesta = Convert.ToInt32(cmd.ExecuteScalar());
                oCnn.Close();
                if (respuesta > 0) return true;
                else return false;
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }
        public bool Escribir(string consulta, ArrayList parametros)
        {
            try
            {
                oCnn.Open();
                Trx = oCnn.BeginTransaction();
                cmd = new SqlCommand(consulta, oCnn, Trx);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parametros != null)
                {
                    foreach (SqlParameter data in parametros)
                    {
                        cmd.Parameters.AddWithValue(data.ParameterName, data.Value);
                    }
                }
                int respuesta = cmd.ExecuteNonQuery();
                Trx.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                Trx.Rollback();
                return false;
            }
            catch (Exception ex)
            {
                Trx.Rollback();
                return false;
            }
            finally { oCnn.Close(); }
        }
    }
}
