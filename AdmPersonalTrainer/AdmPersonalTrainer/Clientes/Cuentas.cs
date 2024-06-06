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
    public partial class Cuentas : Form
    {
        private List<Cliente> _ListaClientes;
        private BLLCliente _BLLCliente;
        private BLLCuenta _BLLCuenta;
        private Cliente _Cliente;
        private VerificadorCuenta _VerificaCuenta;
        public Cuentas()
        {
            _BLLCliente = new BLLCliente();
            _BLLCuenta = new BLLCuenta();
            _VerificaCuenta = new VerificadorCuenta();
            InitializeComponent();

        }
        private void Cuentas_Load(object sender, EventArgs e)
        {
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvClientes.MultiSelect = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            CargarDgvClientes();
            ResetearFormCuenta();
        }
        #region Funciones_Internas
        private void CargarDgvClientes()
        {
            try
            {
                _ListaClientes = _BLLCliente.Listar();
                if (_ListaClientes != null)
                {
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = _ListaClientes;
                    dgvClientes.Columns["Id"].Visible = false;
                    dgvClientes.Columns["Rutina"].Visible = false;
                    dgvClientes.Columns["Cuenta"].Visible = false;
                    dgvClientes.Columns["TelefonoNum"].Visible = false;
                    dgvClientes.Columns["Email"].DisplayIndex = 0;
                }
                else
                {
                    dgvClientes.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hubo un error al cargar los clientes,\nCausa: ${ex}", "Cargar clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Reseteamos campos del formulario 
        private void ResetearFormCuenta()
        {
            pnlCuenta.Visible = false;
            btnActualizarCuenta.Visible = false;
            btnActualizarCuenta.Text = "Actualizar Cuenta";
            cbEditar.Visible = true;
            dtpFechaPago.Enabled = false;
            dtpVencimiento.Enabled = false;
            txtCuentaMonto.Enabled = false;
            txtCuentaMonto.Text = "";
        }
        //Presentamos el form como para crear nueva cuenta.
        private void AgregarCuenta()
        {
            btnActualizarCuenta.Text = "Agregar Cuenta";
            dtpFechaPago.Value = DateTime.Now;
            dtpVencimiento.Value = DateTime.Now.AddMonths(1);
            pnlCuenta.Visible = true;
            btnActualizarCuenta.Visible = true;
            dtpFechaPago.Enabled = true;
            dtpVencimiento.Enabled = true;
            txtCuentaMonto.Enabled = true;
            cbEditar.Visible = false;
            lblEstado.Text = "";
            txtCuentaMonto.Text = "";
        }
        #endregion
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ResetearFormCuenta();
                _Cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                _Cliente.Cuenta = _BLLCuenta.LeerCuenta(_Cliente.Id);
                if (_Cliente.Cuenta != null)
                {
                    pnlCuenta.Visible = true;
                    dtpFechaPago.Value = _Cliente.Cuenta.FechaPago;
                    dtpVencimiento.Value = _Cliente.Cuenta.FechaVencimiento;
                    txtCuentaMonto.Text = _Cliente.Cuenta.Monto.ToString();
                    if (_Cliente.Cuenta.Estado == EnumEstado.Correcto)
                    {
                        lblEstado.Text = "Cuenta al día.";
                        lblEstado.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblEstado.Text = "Cuenta vencida.";
                        lblEstado.ForeColor = Color.Red;
                    }
                }
                else
                {
                    DialogResult respuesta = MessageBox.Show("El cliente no posee una cuenta, ¿desea activarla?", "Cuenta Inexistente.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.Yes)
                    {
                        AgregarCuenta();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtFiltarCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltarCliente.Text.Length > 0)
                {
                    List<Cliente> clientesfiltrado = _ListaClientes.Where(m => m.Nombre.ToLower().Contains(txtFiltarCliente.Text.ToLower()) || m.Apellido.ToLower().Contains(txtFiltarCliente.Text.ToLower())).ToList();
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = clientesfiltrado;
                    dgvClientes.Columns["Id"].Visible = false;
                    dgvClientes.Columns["Rutina"].Visible = false;
                    dgvClientes.Columns["Cuenta"].Visible = false;
                    dgvClientes.Columns["TelefonoNum"].Visible = false;
                    dgvClientes.Columns["Email"].DisplayIndex = 0;
                }
                else
                {
                    CargarDgvClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error al querer filtrar los usuarios.\nCausa: {ex}", "Filtrar clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEditar.Checked == true)
            {
                btnActualizarCuenta.Visible = true;
                dtpFechaPago.Enabled = true;
                dtpVencimiento.Enabled = true;
                txtCuentaMonto.Enabled = true;
            }
            else
            {
                btnActualizarCuenta.Visible = false;
                dtpFechaPago.Enabled = false;
                dtpVencimiento.Enabled = false;
                txtCuentaMonto.Enabled = false;
            }
        }

        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            dtpVencimiento.Value = dtpFechaPago.Value.AddMonths(1);
        }
        #region CREAR_MODIFICAR_CUENTAS
        private void btnActualizarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbEditar.Checked)
                {
                    //editamos
                    if (_VerificaCuenta.CheckForm(dtpFechaPago, dtpVencimiento, txtCuentaMonto))
                    {
                        Cuenta aCuenta = new Cuenta();
                        aCuenta.Id = _Cliente.Cuenta.Id;
                        aCuenta.Cliente = new Cliente();
                        aCuenta.Cliente.Id = _Cliente.Id;
                        aCuenta.FechaPago = dtpFechaPago.Value;
                        aCuenta.FechaVencimiento = dtpVencimiento.Value;
                        aCuenta.Monto = Convert.ToDecimal(txtCuentaMonto.Text);
                        if (_BLLCuenta.Actualizar(aCuenta))
                        {
                            MessageBox.Show("Se ha actualizado con exíto.", "Administrar Cuentas", MessageBoxButtons.OK);
                            CargarDgvClientes();
                            cbEditar.Checked = false;
                            _Cliente = null;
                            ResetearFormCuenta();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al actualizar la cuenta.", "Administrar Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (_VerificaCuenta.CheckForm(dtpFechaPago, dtpVencimiento, txtCuentaMonto))
                    {
                        Cuenta nCuenta = new Cuenta();
                        nCuenta.Cliente = new Cliente();
                        nCuenta.Cliente.Id = _Cliente.Id;
                        nCuenta.FechaPago = dtpFechaPago.Value;
                        nCuenta.FechaVencimiento = dtpVencimiento.Value;
                        nCuenta.Monto = Convert.ToDecimal(txtCuentaMonto.Text);
                        if (_BLLCuenta.Agregar(nCuenta))
                        {
                            MessageBox.Show("Se ha agregado la cuenta con exíto.", "Administrar Cuentas", MessageBoxButtons.OK);
                            CargarDgvClientes();
                            cbEditar.Checked = false;
                            _Cliente = null;
                            ResetearFormCuenta();
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al agregar la cuenta.", "Administrar Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al crear la cuenta.", "Administrar Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al manipular la cuenta.\nCausa {ex}", "Se encontro un error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
