using BE;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AdmPersonalTrainer.Clientes
{
    public partial class ClientesTabla : Form
    {
        private BLLCliente _BLLCliente;
        public ClientesTabla()
        {
            _BLLCliente = new BLLCliente();
            InitializeComponent();
        }
        private void ClientesTabla_Load(object sender, EventArgs e)
        {
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvClientes.MultiSelect = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CargardgvCliente();
        }
        private void CargardgvCliente()
        {
            try
            {
                List<Cliente> listaClientes = _BLLCliente.ListarClientes();
                if(listaClientes != null)
                {
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = listaClientes;
                    dgvClientes.Columns["Rutina"].Visible = false;
                    dgvClientes.Columns["Cuenta"].Visible = false;
                    dgvClientes.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar la grilla.\nCausa: {ex}.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            


        }
    }
}
