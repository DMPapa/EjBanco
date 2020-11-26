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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            frmCuentas cuentas = new frmCuentas();
            cuentas.Owner = this;
            cuentas.Show();
            this.Hide();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            frmPrestamos prestamos = new frmPrestamos();
            prestamos.Owner = this;
            prestamos.Show();
            this.Hide();
        }
    }
}
