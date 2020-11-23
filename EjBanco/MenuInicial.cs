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
    public partial class MenuInicial : Form
    {
        public MenuInicial()
        {
            InitializeComponent();
        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            frmClientes frmclientes = new frmClientes();
            frmclientes.Owner = this;
            frmclientes.Show();
            this.Hide();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            frmProductos frmproductos = new frmProductos();
            frmproductos.Owner = this;
            frmproductos.Show();
            this.Hide();
        }
    }
}
