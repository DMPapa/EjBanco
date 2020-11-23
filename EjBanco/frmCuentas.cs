using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjBanco.Negocio;

namespace EjBanco
{
    public partial class frmCuentas : Form
    {
        private CuentaServicio cuentaservicio;
        public frmCuentas()
        {
            InitializeComponent();
        }


        private void frmCuentas_Load(object sender, EventArgs e)
        {
            cuentaservicio = new CuentaServicio();
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            dataCuentas.DataSource = cuentaservicio.TraerCuentas();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaCuenta alta = new frmAltaCuenta();
            alta.Owner = this;
            alta.Show();
            this.Hide();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
