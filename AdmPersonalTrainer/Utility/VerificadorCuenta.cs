using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public class VerificadorCuenta : Verificador
    {
        public bool CheckForm(DateTimePicker fechaPago,DateTimePicker fechaVencimiento,TextBox txtmonto)
        {
            if(fechaPago.Value < fechaVencimiento.Value)
            {
                if (!CampoVacio(txtmonto))
                {
                    if (EsDecimal(txtmonto))
                    {
                        return true;
                    }
                    MessageBox.Show("El formato del campo debe ser decimal.", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
                MessageBox.Show("Debe completar el campo monto.", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("La fecha de pago no puede ser posterior a la del vencimiento.", "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
