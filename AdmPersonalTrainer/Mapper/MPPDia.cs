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
    public class MPPDia
    {
        AccesoParametro _accParametro;
        public List<Dia> Listar()
        {
            try
            {
                _accParametro = new AccesoParametro();
                string query = "SpDia_Listar";
                List<Dia> lista = new List<Dia>();
                DataTable table;
                table = _accParametro.leer(query, null);
                if(table.Rows.Count > 0)
                {
                    foreach(DataRow row in table.Rows)
                    {
                        Dia dia = new Dia();
                        dia.Id = Convert.ToInt32(row[0]);
                        dia.Descripcion = row[1].ToString().Trim();
                        lista.Add(dia);
                    }
                    return lista;
                }
                return lista = null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
