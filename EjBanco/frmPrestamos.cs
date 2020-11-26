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
    public partial class frmPrestamos : Form
    {
        private PrestamoServicio prestamoservicio;
        private PrestamoTipoServicio prestamotiposervicio;
        private ClienteServicio clienteservicio;
        private Operador p;
        int[] j;
        
        public frmPrestamos()
        {
            InitializeComponent();
                        this.cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            prestamoservicio = new PrestamoServicio();
            prestamotiposervicio = new PrestamoTipoServicio();
            clienteservicio = new ClienteServicio();
            lstPrestamoTipo.DataSource = prestamotiposervicio.TraerTiposDePrestamos();
            lstPrestamos.DataSource = prestamoservicio.TraerPrestamosOperador();
            txtComisionTotal.Text = CalcularComisionTotal().ToString();
            LlenarCmbCliente();
            LlenarCmbPlazo();


            
        }

        private void LlenarCmbPlazo() 
        {
            int[] num = new int[35];
            int j = 0;
            for (int i = 0; i <= 6; i += 1)
            {
                num[j] = i;
                j++;
            }
            cmbPlazo.DataSource = null;
            cmbPlazo.DataSource = num;
            cmbPlazo.SelectedIndex = -1;
        }
        private void LlenarCmbCliente()
        {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = clienteservicio.TraerClientes();
            cmbCliente.SelectedIndex = -1;
        }

        private double CalcularComisionTotal()
        {
            double comisiontotal = 0;
            foreach (Operador p in prestamoservicio.TraerPrestamosOperador())
            {
                comisiontotal += p.Comision;
            }
            return comisiontotal;
        }
        private void lstPrestamoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLinea.Text = ((PrestamoTipo)lstPrestamoTipo.SelectedItem).Linea;
            txtTNA.Text = ((PrestamoTipo)lstPrestamoTipo.SelectedItem).TNA.ToString();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.errores))
                throw new Exception("Error en los campos: " + "\n" + this.errores);
            else
            {
                p = new Operador(new Prestamo(prestamoservicio.ProximoId(),
                                              Double.Parse(txtTNA.Text),
                                              txtLinea.Text,
                                              cmbPlazo.SelectedIndex,
                                              ((Cliente)cmbCliente.SelectedItem).Id,
                                              ((PrestamoTipo)lstPrestamoTipo.SelectedItem).Id,
                                              double.Parse(txtMonto.Text),
                                              (PrestamoTipo)lstPrestamoTipo.SelectedItem));
                prestamoservicio.SimularCuotaCapital(p);
                prestamoservicio.SimularCuotaInteres(p);
                txtMonto.ReadOnly = true;
            }
        }
        private string errores
        {
            get
            {
                return Validacion.ValidarDouble(txtMonto.Text, "double");
            }
        }
        private void btnAlta_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.errores))
                throw new Exception("Error en los campos: " + "\n" + this.errores);
            else
            {
                prestamoservicio.InsertarPrestamo(p.Prestamo);
            }
            LimpiarFrmPrestamo();
        }
        private void LimpiarFrmPrestamo()
        {
            txtLinea.Clear();
            txtMonto.Clear();
            txtTNA.Clear();
            cmbCliente.SelectedIndex = -1;
            cmbPlazo.SelectedIndex = -1;
            txtCuotaCap.Clear();
            txtCuotaInt.Clear();
            txtCuotaTotal.Clear();
            lstPrestamos.DataSource = prestamoservicio.TraerPrestamosOperador();

        }
    }
}
