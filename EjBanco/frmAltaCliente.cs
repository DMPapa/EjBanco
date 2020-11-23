using EjBanco.Entidades;
using EjBanco.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjBanco
{
    public partial class frmAltaCliente : Form
    {
        private ClienteServicio clienteservicio;
        public frmAltaCliente()
        {
            InitializeComponent();
        }
        private void frmAltaCliente_Load(object sender, EventArgs e)
        {
            clienteservicio = new ClienteServicio();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(this.Errores))
                throw new FormatException("Error en los campos: " + "\n" + this.Errores);
            else
            clienteservicio.InsertarCliente(int.Parse(txtDNI.Text),
                                txtNombre.Text,
                                txtApellido.Text,
                                txtEmail.Text,
                                txtTelefono.Text,
                                dateTimePicker1.Value,
                                true,
                                clienteservicio.ProximoId());
            MessageBox.Show("Se ha ingresado correctamente el cliente");
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
        private void BorrarCampos()
        {
            txtApellido.Clear();
            txtDireccion.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
        }
        private string Errores
        {
            get
            {
                return (Validacion.ValidarString(txtApellido.Text, "Apellido") +
                        Validacion.ValidarString(txtDireccion.Text, "Dirección") +
                        Validacion.ValidarNumero(txtDNI.Text, "DNI") +
                        Validacion.ValidarString(txtEmail.Text, "Email") +
                        Validacion.ValidarString(txtNombre.Text, "Nombre") +
                        Validacion.ValidarNumero(txtTelefono.Text, "Telefono"));


            }
        }
    }
}
