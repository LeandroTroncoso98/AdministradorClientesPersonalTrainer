using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public class VerificadorCliente : Verificador
    {
        public bool CheckNombre(TextBox txtnombre)
        {
            if (!CampoVacio(txtnombre))
            {
                return true;
            }
            return false;
        }
        public bool CheckApellido(TextBox txtApellido)
        {
            if (!CampoVacio(txtApellido))
            {
                return true;
            }
            return false;
        }
        public bool CheckEmail(TextBox txtEmail)
        {
            if (!CampoVacio(txtEmail))
            {
                if (FormatoCorreo(txtEmail))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool CheckNumero(TextBox txtNumero)
        {
            if (!CampoVacio(txtNumero))
            {
                if (EsNumerico(txtNumero))
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
