using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjBanco.Entidades;
using EjBanco.Negocio;

namespace EjBanco
{
    public partial class frmAltaCuenta : Form
    {
        private CuentaServicio cuentaservicio;
        private ClienteServicio clienteservicio;
        public frmAltaCuenta()
        {
            InitializeComponent();
            this.cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmAltaCuenta_Load(object sender, EventArgs e)
        {

            cuentaservicio = new CuentaServicio();
            clienteservicio = new ClienteServicio();
            LlenarCmb();
        }

        private void LlenarCmb()
        {
            cmbCliente.DataSource = clienteservicio.TraerClientes();
            cmbCliente.SelectedIndex = -1;
            CargarDescpiciones();
            cmbDescripcion.SelectedIndex = -1;
        }
        private void CargarDescpiciones()
        {
            cmbDescripcion.Items.Add("CC$");
            cmbDescripcion.Items.Add("CA$");
            cmbDescripcion.Items.Add("CAu$s");
        }
        private void BorrarCampos()
        {
            txtCuenta.Clear();
            txtSaldo.Clear();
            cmbCliente.SelectedIndex = -1;
            cmbDescripcion.SelectedIndex = -1;
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.errores))
                throw new FormatException("Error en los campos: " + "\n" + this.errores);
            else
                cuentaservicio.InsertarCuenta(int.Parse(txtCuenta.Text),
                                              cmbDescripcion.SelectedItem.ToString(),
                                              float.Parse(txtSaldo.Text),
                                              ((Cliente)cmbCliente.SelectedItem).Id,
                                              cuentaservicio.ProximoId());
            MessageBox.Show("Se ha ingresado correctamente la cuenta");
            BorrarCampos();
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCampos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
        private string errores
        {
            get
            {
                return (Validacion.ValidarNumero(txtCuenta.Text, "Cuenta") +
                        Validacion.ValidarFloat(txtSaldo.Text, "Saldo"));

            }
        }
    }
}
