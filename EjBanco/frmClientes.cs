using EjBanco.Negocio;
using EjBanco.Entidades;
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
    public partial class frmClientes : Form
    {
        private ClienteServicio clienteservicio;
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            clienteservicio = new ClienteServicio();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaCliente altacliente = new frmAltaCliente();
            altacliente.Owner = this;
            altacliente.Show();
            this.Hide();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Cliente> lista = new List<Cliente>();

            lista = clienteservicio.TraerClientes();

            dataClientes.DataSource = lista;
        }


    }
}
