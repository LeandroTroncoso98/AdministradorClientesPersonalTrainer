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
        public bool CheckForm(TextBox txtNombre,TextBox txtApellido, TextBox txtEmail, TextBox txtNumero)
        {
            if (!CampoVacio(txtNombre))
            {
                if (!CampoVacio(txtApellido))
                {
                    if (!CampoVacio(txtEmail))
                    {
                        if (FormatoCorreo(txtEmail))
                        {
                            if (!CampoVacio(txtNumero))
                            {
                                if (EsNumerico(txtNumero))
                                {
                                    return true;
                                }
                                MessageBox.Show("Debe ser un campo numero.", "Error Formulario Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                            MessageBox.Show("Debe completar el campo de numero telefonico.", "Error Formulario Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        MessageBox.Show("El formato del correo no es correcto.", "Error Formulario Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    MessageBox.Show("Debe completar el campo el campo de email.", "Error Formulario Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                MessageBox.Show("Debe completar el campo apellido.", "Error Formulario Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            MessageBox.Show("Debe completar el campo nombre.", "Error Formulario Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
