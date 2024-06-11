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
    public partial class RutinaForm : Form
    {
        //variables de negocio.
        private BLLDia _BLLDia;
        private BLLCliente _BLLCliente;
        private BLLRutina _BLLRutina;
        
        
        //variables globales.
        private List<Cliente> _ListaClientes;
        private Cliente _cliente;

        //Verificadores
        VerificadorRutina _verificadorRutina;


        public RutinaForm()
        {
            _BLLDia = new BLLDia();
            _BLLCliente = new BLLCliente();
            _BLLRutina = new BLLRutina();
            _verificadorRutina = new VerificadorRutina();
            InitializeComponent();
        }

        private void RutinaForm_Load(object sender, EventArgs e)
        {
            CargarCbDia();
            CargarDgvCliente();
            pnlRutina.Visible = false;
            pnlDiaFormEjercicio.Visible = false;
        }
        #region funciones de carga
        public void CargarCbDia()
        {
            cbDias.DataSource = null;
            cbDias.DataSource = _BLLDia.Listar();
            cbDias.DisplayMember = "Descripcion";
            cbDias.ValueMember = "Id";
            cbDias.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void CargarDgvCliente(bool filtrado = false,List<Cliente> listaFiltrada = null)
        {
            try
            {
                dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvClientes.EditMode = DataGridViewEditMode.EditProgrammatically;
                dgvClientes.MultiSelect = false;
                dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvClientes.DataSource = null;
                //Si el llamado a la funcion no es para filtrar
                if (!filtrado)
                {
                    _ListaClientes = _BLLCliente.Listar();
                }
                else
                {
                    //Si es para filtrar enviamos la lista filtrada ingresada en el parametro
                    _ListaClientes = listaFiltrada; 
                }
                if (_ListaClientes != null)
                {
                    dgvClientes.DataSource = _ListaClientes;
                    dgvClientes.Columns["Id"].Visible = false;
                    dgvClientes.Columns["Rutina"].Visible = false;
                    dgvClientes.Columns["Cuenta"].Visible = false;
                    dgvClientes.Columns["TelefonoNum"].Visible = false;
                    dgvClientes.Columns["Email"].DisplayIndex = 0;

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void CargarTxtRutinaObjetivo(Rutina rutina = null)
        {
            txtRutinaObjetivo.Text = "";
            pnlRutina.Visible = true;
            pnlDiaFormEjercicio.Visible = false;
            if (rutina != null)
            {
                txtRutinaObjetivo.Text = rutina.Objetivo.Trim();
                btnRutinaObjetivo.Text = "Cambiar Objetivo";
                pnlDiaFormEjercicio.Visible = true;
            }
            else
            {
                btnRutinaObjetivo.Text = "Nuevo Objetivo";
            }
        }
        #endregion

        private void txtFiltarCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtFiltrarCliente.Text.Length > 0)
                {
                    List<Cliente> listaFiltrada = _ListaClientes.Where(m => m.Nombre.ToLower().Trim().Contains(txtFiltrarCliente.Text.ToLower().Trim()) || m.Apellido.ToLower().Trim().Contains(txtFiltrarCliente.Text.ToLower().Trim())).ToList();
                    if(listaFiltrada.Count > 0)
                    {
                        CargarDgvCliente(true, listaFiltrada);
                    }
                }
                else
                {
                    CargarDgvCliente();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                _cliente.Rutina = _BLLRutina.LeerRutina(_cliente.Id);
                CargarTxtRutinaObjetivo(_cliente.Rutina);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"No se pudo seleccionar el cliente.\nCausa:{ex}", "Error al seleccionar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRutinaObjetivo_Click(object sender, EventArgs e)
        {
            try
            {
                if (_verificadorRutina.CheckForm(txtRutinaObjetivo))
                {
                    Rutina rutina = new Rutina();
                    rutina.Objetivo = txtRutinaObjetivo.Text.Trim();
                    rutina.Cliente = new Cliente();
                    rutina.Cliente.Id = _cliente.Id;
                    if (btnRutinaObjetivo.Text == "Cambiar Objetivo")
                    {
                        if (_BLLRutina.Actualizar(rutina))
                        {
                            MessageBox.Show("Se ha actualizado con exíto");
                            this.RutinaForm_Load(sender,e);
                        }
                        else MessageBox.Show("Hubo un error al actualizar la rutina.", "Actualizar Rutina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (_BLLRutina.Agregar(rutina))
                        {
                            MessageBox.Show("Se ha creado con exíto");
                            this.RutinaForm_Load(sender, e);
                        }
                        else MessageBox.Show("Hubo un error al agregar la rutina.", "Agregar Rutina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"No se pudo realizar la rutina.\nCausa:{ex}", "Error en rutina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
