namespace EjBanco
{
    partial class frmPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblPrestamosAlta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.lblCuotaTotal = new System.Windows.Forms.Label();
            this.txtCuotaInt = new System.Windows.Forms.TextBox();
            this.lblCuotaInteres = new System.Windows.Forms.Label();
            this.txtCuotaCap = new System.Windows.Forms.TextBox();
            this.lblCapital = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.cmbPlazo = new System.Windows.Forms.ComboBox();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lstPrestamoTipo = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtComisionTotal = new System.Windows.Forms.TextBox();
            this.lblComisionTotal = new System.Windows.Forms.Label();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.Location = new System.Drawing.Point(3, 10);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(163, 20);
            this.lblPrestamo.TabIndex = 0;
            this.lblPrestamo.Text = "TIPOS PRESTAMO";
            // 
            // lblPrestamosAlta
            // 
            this.lblPrestamosAlta.AutoSize = true;
            this.lblPrestamosAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamosAlta.Location = new System.Drawing.Point(3, 10);
            this.lblPrestamosAlta.Name = "lblPrestamosAlta";
            this.lblPrestamosAlta.Size = new System.Drawing.Size(265, 20);
            this.lblPrestamosAlta.TabIndex = 1;
            this.lblPrestamosAlta.Text = "PRESTAMOS DADOS DE ALTA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.btnAlta);
            this.panel1.Controls.Add(this.txtCuotaTotal);
            this.panel1.Controls.Add(this.lblCuotaTotal);
            this.panel1.Controls.Add(this.txtCuotaInt);
            this.panel1.Controls.Add(this.lblCuotaInteres);
            this.panel1.Controls.Add(this.txtCuotaCap);
            this.panel1.Controls.Add(this.lblCapital);
            this.panel1.Controls.Add(this.btnSimular);
            this.panel1.Controls.Add(this.cmbPlazo);
            this.panel1.Controls.Add(this.lblPlazo);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Controls.Add(this.txtTNA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtLinea);
            this.panel1.Controls.Add(this.lblLinea);
            this.panel1.Controls.Add(this.lstPrestamoTipo);
            this.panel1.Controls.Add(this.lblPrestamo);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 413);
            this.panel1.TabIndex = 2;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(241, 27);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(148, 21);
            this.cmbCliente.TabIndex = 21;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(194, 27);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 16);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Cliente";
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(197, 376);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(192, 23);
            this.btnAlta.TabIndex = 19;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click_1);
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.Location = new System.Drawing.Point(258, 344);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.ReadOnly = true;
            this.txtCuotaTotal.Size = new System.Drawing.Size(131, 20);
            this.txtCuotaTotal.TabIndex = 18;
            // 
            // lblCuotaTotal
            // 
            this.lblCuotaTotal.AutoSize = true;
            this.lblCuotaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaTotal.Location = new System.Drawing.Point(194, 332);
            this.lblCuotaTotal.Name = "lblCuotaTotal";
            this.lblCuotaTotal.Size = new System.Drawing.Size(55, 32);
            this.lblCuotaTotal.TabIndex = 17;
            this.lblCuotaTotal.Text = "CUOTA\r\nTOTAL\r\n";
            this.lblCuotaTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCuotaInt
            // 
            this.txtCuotaInt.Location = new System.Drawing.Point(258, 303);
            this.txtCuotaInt.Name = "txtCuotaInt";
            this.txtCuotaInt.ReadOnly = true;
            this.txtCuotaInt.Size = new System.Drawing.Size(131, 20);
            this.txtCuotaInt.TabIndex = 16;
            // 
            // lblCuotaInteres
            // 
            this.lblCuotaInteres.AutoSize = true;
            this.lblCuotaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaInteres.Location = new System.Drawing.Point(194, 291);
            this.lblCuotaInteres.Name = "lblCuotaInteres";
            this.lblCuotaInteres.Size = new System.Drawing.Size(56, 32);
            this.lblCuotaInteres.TabIndex = 15;
            this.lblCuotaInteres.Text = "Cuota\r\n(Interes)\r\n";
            this.lblCuotaInteres.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCuotaCap
            // 
            this.txtCuotaCap.Location = new System.Drawing.Point(258, 261);
            this.txtCuotaCap.Name = "txtCuotaCap";
            this.txtCuotaCap.ReadOnly = true;
            this.txtCuotaCap.Size = new System.Drawing.Size(131, 20);
            this.txtCuotaCap.TabIndex = 14;
            // 
            // lblCapital
            // 
            this.lblCapital.AutoSize = true;
            this.lblCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapital.Location = new System.Drawing.Point(194, 249);
            this.lblCapital.Name = "lblCapital";
            this.lblCapital.Size = new System.Drawing.Size(58, 32);
            this.lblCapital.TabIndex = 13;
            this.lblCapital.Text = "Cuota\r\n(Capital)\r\n";
            this.lblCapital.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(197, 219);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(192, 23);
            this.btnSimular.TabIndex = 12;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            // 
            // cmbPlazo
            // 
            this.cmbPlazo.FormattingEnabled = true;
            this.cmbPlazo.Location = new System.Drawing.Point(241, 179);
            this.cmbPlazo.Name = "cmbPlazo";
            this.cmbPlazo.Size = new System.Drawing.Size(148, 21);
            this.cmbPlazo.TabIndex = 11;
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazo.Location = new System.Drawing.Point(194, 179);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(42, 16);
            this.lblPlazo.TabIndex = 9;
            this.lblPlazo.Text = "Plazo";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(241, 138);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(148, 20);
            this.txtMonto.TabIndex = 8;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(194, 139);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(45, 16);
            this.lblMonto.TabIndex = 7;
            this.lblMonto.Text = "Monto";
            // 
            // txtTNA
            // 
            this.txtTNA.Location = new System.Drawing.Point(241, 98);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.ReadOnly = true;
            this.txtTNA.Size = new System.Drawing.Size(148, 20);
            this.txtTNA.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "TNA";
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(241, 60);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.ReadOnly = true;
            this.txtLinea.Size = new System.Drawing.Size(148, 20);
            this.txtLinea.TabIndex = 4;
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.Location = new System.Drawing.Point(194, 61);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(41, 16);
            this.lblLinea.TabIndex = 3;
            this.lblLinea.Text = "Linea";
            // 
            // lstPrestamoTipo
            // 
            this.lstPrestamoTipo.FormattingEnabled = true;
            this.lstPrestamoTipo.Location = new System.Drawing.Point(7, 44);
            this.lstPrestamoTipo.Name = "lstPrestamoTipo";
            this.lstPrestamoTipo.Size = new System.Drawing.Size(181, 355);
            this.lstPrestamoTipo.TabIndex = 2;
            this.lstPrestamoTipo.SelectedIndexChanged += new System.EventHandler(this.lstPrestamoTipo_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtComisionTotal);
            this.panel2.Controls.Add(this.lblComisionTotal);
            this.panel2.Controls.Add(this.lstPrestamos);
            this.panel2.Controls.Add(this.lblPrestamosAlta);
            this.panel2.Location = new System.Drawing.Point(437, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 413);
            this.panel2.TabIndex = 3;
            // 
            // txtComisionTotal
            // 
            this.txtComisionTotal.Location = new System.Drawing.Point(169, 368);
            this.txtComisionTotal.Name = "txtComisionTotal";
            this.txtComisionTotal.ReadOnly = true;
            this.txtComisionTotal.Size = new System.Drawing.Size(168, 20);
            this.txtComisionTotal.TabIndex = 14;
            // 
            // lblComisionTotal
            // 
            this.lblComisionTotal.AutoSize = true;
            this.lblComisionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComisionTotal.Location = new System.Drawing.Point(17, 369);
            this.lblComisionTotal.Name = "lblComisionTotal";
            this.lblComisionTotal.Size = new System.Drawing.Size(127, 20);
            this.lblComisionTotal.TabIndex = 13;
            this.lblComisionTotal.Text = "Comisión Total";
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.Location = new System.Drawing.Point(7, 44);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(330, 303);
            this.lstPrestamos.TabIndex = 3;
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frmPrestamos";
            this.Text = "frmPrestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblPrestamosAlta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.ListBox lstPrestamoTipo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.ComboBox cmbPlazo;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.TextBox txtComisionTotal;
        private System.Windows.Forms.Label lblComisionTotal;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.Label lblCuotaTotal;
        private System.Windows.Forms.TextBox txtCuotaInt;
        private System.Windows.Forms.Label lblCuotaInteres;
        private System.Windows.Forms.TextBox txtCuotaCap;
        private System.Windows.Forms.Label lblCapital;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
    }
}