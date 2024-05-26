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
using Utility;

namespace AdmPersonalTrainer.Clientes
{
    public partial class ClientesTabla : Form
    {
        private BLLCliente _BLLCliente;
        public List<Cliente> listaClientes;
        private VerificadorCliente _VerificadorCliente;
        private Cliente _ClienteSelect;
        public ClientesTabla()
        {
            _BLLCliente = new BLLCliente();
            _VerificadorCliente = new VerificadorCliente();
            _ClienteSelect = new Cliente();
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
                listaClientes = _BLLCliente.Listar();
                if (listaClientes != null)
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
                MessageBox.Show($"No se pudo cargar la grilla.\nCausa: {ex}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void VaciasCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtFiltro.Text = "";
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text.Length > 0)
            {
                List<Cliente> clientesfiltrado = listaClientes.Where(m => m.Nombre.ToLower().Contains(txtFiltro.Text.ToLower()) || m.Apellido.ToLower().Contains(txtFiltro.Text.ToLower())).ToList();
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clientesfiltrado;
                dgvClientes.Columns["Rutina"].Visible = false;
                dgvClientes.Columns["Cuenta"].Visible = false;
                dgvClientes.Columns["Id"].Visible = false;
            }
            else
            {
                CargardgvCliente();
            }


        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (_VerificadorCliente.CheckForm(txtNombre, txtApellido, txtEmail, txtTelefono))
                {
                    Cliente cliente = new Cliente();
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.TelefonoNum = txtTelefono.Text;
                    cliente.Email = txtEmail.Text;
                    if (_BLLCliente.Agregar(cliente))
                    {
                        MessageBox.Show("Se ha agregado con exíto.");
                        CargardgvCliente();
                        VaciasCampos();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurrido el siguiente error.\nCausa: {ex}", "Agregar cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (_VerificadorCliente.CheckForm(txtNombre, txtApellido, txtEmail, txtTelefono))
                {
                    Cliente clienteAct = new Cliente();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurrido el siguiente error.\nCausa: {ex}", "Actualizar cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _ClienteSelect = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                txtNombre.Text = _ClienteSelect.Nombre;
                txtApellido.Text = _ClienteSelect.Apellido;
                txtTelefono.Text = _ClienteSelect.TelefonoNum;
                txtEmail.Text = _ClienteSelect.Email;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ha ocurrido el siguiente error.\nCausa: {ex}", "Seleccionar cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
