using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public class VerificadorRutina : Verificador
    {
        public bool CheckForm(TextBox txtObjetivo)
        {
            if (!CampoVacio(txtObjetivo))
            {
                return true;
            }
            MessageBox.Show("Debe llenar el campo objetivo", "Formulario Rutina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
