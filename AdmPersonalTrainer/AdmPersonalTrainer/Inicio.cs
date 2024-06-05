using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AdmPersonalTrainer.Clientes;

namespace AdmPersonalTrainer
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            BtnRestaurar.Visible = false;
        }
        #region botones
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }
        #endregion
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #region movimientoForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void AbrirFormChild(object formhijo)
        {
            if(this.Contenedor.Controls.Count > 0)
            {
                this.Contenedor.Controls.RemoveAt(0);
                Form fh = formhijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.Contenedor.Controls.Add(fh);
                this.Contenedor.Tag = fh;
                fh.Show();

            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormChild(new ClientesTabla());
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            AbrirFormChild(new Cuentas());
        }
    }
}
