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
        private List<Cliente> listaClientes;
        private VerificadorCliente _VerificadorCliente;
        private Cliente _ClienteSelect;
        public ClientesTabla()
        {
            _BLLCliente = new BLLCliente();
            _VerificadorCliente = new VerificadorCliente();
            _ClienteSelect = null;
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
                    if (!_BLLCliente.ExisteEmail(cliente.Email))
                    {
                        if (_BLLCliente.Agregar(cliente))
                        {
                            MessageBox.Show("Se ha agregado con exíto.");
                            CargardgvCliente();
                            VaciasCampos();
                            _ClienteSelect = null;
                        }
                    }
                    else MessageBox.Show("El correo electronico ya lo posee otro usuario.", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido el siguiente error.\nCausa: {ex}", "Agregar cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (_ClienteSelect != null)
                {
                    if (_VerificadorCliente.CheckForm(txtNombre, txtApellido, txtEmail, txtTelefono))
                    {

                        if (_VerificadorCliente.CheckForm(txtNombre, txtApellido, txtEmail, txtTelefono))
                        {
                            if (!_BLLCliente.ExisteEmail(txtEmail.Text, _ClienteSelect.Id))
                            {
                                _ClienteSelect.Nombre = txtNombre.Text;
                                _ClienteSelect.Apellido = txtApellido.Text;
                                _ClienteSelect.Email = txtEmail.Text;
                                _ClienteSelect.TelefonoNum = txtTelefono.Text;
                                if (_BLLCliente.Actualizar(_ClienteSelect))
                                {
                                    MessageBox.Show("Se ha actualizado con exíto");
                                    VaciasCampos();
                                    _ClienteSelect = null;
                                    CargardgvCliente();
                                }
                            }
                            else MessageBox.Show("El correo electronico ya lo posee otro usuario.", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else MessageBox.Show("Debe seleccionar un cliente.", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido el siguiente error.\nCausa: {ex}", "Seleccionar cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if(_ClienteSelect != null)
                {
                    DialogResult resultado = MessageBox.Show($"¿Esta seguro de que desea eliminar a {_ClienteSelect.Nombre} {_ClienteSelect.Apellido} de la base de datos?", "Borrar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if(resultado == DialogResult.Yes)
                    {
                        if (_BLLCliente.Borrar(_ClienteSelect.Id))
                        {
                            MessageBox.Show("Se ha borrado con exíto");
                            VaciasCampos();
                            CargardgvCliente();
                            _ClienteSelect = null;
                        }
                    }
                }
                else MessageBox.Show($"Debe seleccionar un cliente.", "Borrar cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ha ocurrido el siguiente error.\nCausa: {ex}", "Borrar cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
