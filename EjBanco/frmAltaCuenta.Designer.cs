namespace EjBanco
{
    partial class frmAltaCuenta
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
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblNroCuenta = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.cmbDescripcion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.Location = new System.Drawing.Point(201, 44);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(232, 31);
            this.lblDatosCliente.TabIndex = 1;
            this.lblDatosCliente.Text = "Datos del cliente";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(31, 119);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 29);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(31, 170);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 29);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(31, 300);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(108, 29);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblNroCuenta
            // 
            this.lblNroCuenta.AutoSize = true;
            this.lblNroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCuenta.Location = new System.Drawing.Point(203, 174);
            this.lblNroCuenta.Name = "lblNroCuenta";
            this.lblNroCuenta.Size = new System.Drawing.Size(105, 20);
            this.lblNroCuenta.TabIndex = 19;
            this.lblNroCuenta.Text = "Nro Cuenta:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(203, 220);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(108, 20);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(203, 268);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(106, 20);
            this.lblSaldo.TabIndex = 21;
            this.lblSaldo.Text = "Saldo incial:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(203, 128);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 20);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Cliente:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(353, 125);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(194, 21);
            this.cmbCliente.TabIndex = 23;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(353, 176);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(194, 20);
            this.txtCuenta.TabIndex = 24;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(353, 270);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(194, 20);
            this.txtSaldo.TabIndex = 26;
            // 
            // cmbDescripcion
            // 
            this.cmbDescripcion.FormattingEnabled = true;
            this.cmbDescripcion.Location = new System.Drawing.Point(353, 220);
            this.cmbDescripcion.Name = "cmbDescripcion";
            this.cmbDescripcion.Size = new System.Drawing.Size(194, 21);
            this.cmbDescripcion.TabIndex = 27;
            // 
            // frmAltaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(614, 362);
            this.Controls.Add(this.cmbDescripcion);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNroCuenta);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDatosCliente);
            this.Name = "frmAltaCuenta";
            this.Text = "frmAltaCuenta";
            this.Load += new System.EventHandler(this.frmAltaCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblNroCuenta;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.ComboBox cmbDescripcion;
    }
}