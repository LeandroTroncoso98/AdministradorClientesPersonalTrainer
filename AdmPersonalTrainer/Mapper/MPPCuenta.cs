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
    public class MPPCuenta : IAdministrable<Cuenta>
    {
        private AccesoParametro _accParametros;
        private ArrayList _al;


        public bool Actualizar(Cuenta aCuenta)
        {
            try
            {
                string query = "SpCuenta_Actualizar";
                _al = new ArrayList();
                _accParametros = new AccesoParametro();
                SqlParameter prm1 = new SqlParameter("@Id", SqlDbType.Int);
                prm1.Value = aCuenta.Id;
                _al.Add(prm1);
                SqlParameter prm2 = new SqlParameter("@Usuario_Id", SqlDbType.Int);
                prm2.Value = aCuenta.Cliente.Id;
                _al.Add(prm2);
                SqlParameter prm3 = new SqlParameter("@FechaPago", SqlDbType.DateTime);
                prm3.Value = aCuenta.FechaPago;
                _al.Add(prm3);
                SqlParameter prm4 = new SqlParameter("@FechaVencimiento", SqlDbType.DateTime);
                prm4.Value = aCuenta.FechaVencimiento;
                _al.Add(prm4);
                SqlParameter prm5 = new SqlParameter("@Monto", SqlDbType.Decimal);
                prm5.Value = aCuenta.Monto;
                _al.Add(prm5);
                return _accParametros.Escribir(query, _al);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Agregar(Cuenta nCuenta)
        {
            try
            {
                string query = "SpCuenta_Crear";
                _accParametros = new AccesoParametro();
                _al = new ArrayList();
                SqlParameter prm1 = new SqlParameter("@Usuario_Id", SqlDbType.Int);
                prm1.Value = nCuenta.Cliente.Id;
                _al.Add(prm1);
                SqlParameter prm2 = new SqlParameter("@FechaPago", SqlDbType.DateTime);
                prm2.Value = nCuenta.FechaPago;
                _al.Add(prm2);
                SqlParameter prm3 = new SqlParameter("@FechaVencimiento", SqlDbType.DateTime);
                prm3.Value = nCuenta.FechaVencimiento;
                _al.Add(prm3);
                SqlParameter prm4 = new SqlParameter("@Monto", SqlDbType.Decimal);
                prm4.Value = nCuenta.Monto;
                _al.Add(prm4);
                return _accParametros.Escribir(query, _al);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool Borrar(int usuario_Id)
        {
            try
            {
                string query = "SpCuenta_Borrar";
                _al = new ArrayList();
                _accParametros = new AccesoParametro();
                SqlParameter prm1 = new SqlParameter("@Usuario_Id", SqlDbType.Int);
                prm1.Value = usuario_Id;
                _al.Add(prm1);
                return _accParametros.Escribir(query, _al);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public Cuenta LeerCuenta(int idCliente)
        {
            try
            {
                string query = "SpCuenta_Leer";
                _accParametros = new AccesoParametro();
                SqlParameter prm1 = new SqlParameter("@Usuario_Id", SqlDbType.Int);
                prm1.Value = idCliente;
                _al = new ArrayList();
                _al.Add(prm1);
                DataTable table = _accParametros.leer(query, _al);
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    Cuenta cuenta = new Cuenta();
                    cuenta.Id = Convert.ToInt32(row[0]);
                    cuenta.FechaPago = Convert.ToDateTime(row[1]);
                    cuenta.FechaVencimiento = Convert.ToDateTime(row[2]);
                    cuenta.Monto = Convert.ToDecimal(row[3]);
                    cuenta.Estado = AsignarEstado(cuenta.FechaVencimiento);
                    cuenta.Cliente = new Cliente();
                    cuenta.Cliente.Id = idCliente;
                    return cuenta;
                }
                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        private EnumEstado AsignarEstado(DateTime fechaVencimiento)
        {
            if(fechaVencimiento > DateTime.Now)
            {
                return EnumEstado.Correcto;
            }
            return EnumEstado.Vencido;
        }
    }
}
