namespace EjBanco
{
    partial class frmProductos
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
            this.lblTituloProductos = new System.Windows.Forms.Label();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnPF = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnTC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.AutoSize = true;
            this.lblTituloProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProductos.Location = new System.Drawing.Point(12, 24);
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Size = new System.Drawing.Size(303, 31);
            this.lblTituloProductos.TabIndex = 0;
            this.lblTituloProductos.Text = "Selecciones producto:";
            // 
            // btnCuentas
            // 
            this.btnCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentas.Location = new System.Drawing.Point(34, 87);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(252, 45);
            this.btnCuentas.TabIndex = 1;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = true;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click);
            // 
            // btnPF
            // 
            this.btnPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPF.Location = new System.Drawing.Point(34, 285);
            this.btnPF.Name = "btnPF";
            this.btnPF.Size = new System.Drawing.Size(252, 45);
            this.btnPF.TabIndex = 2;
            this.btnPF.Text = "Plazos Fijos";
            this.btnPF.UseVisualStyleBackColor = true;
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.Location = new System.Drawing.Point(34, 215);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(252, 45);
            this.btnPrestamos.TabIndex = 3;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnTC
            // 
            this.btnTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTC.Location = new System.Drawing.Point(34, 152);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(252, 45);
            this.btnTC.TabIndex = 4;
            this.btnTC.Text = "Tarjetas de Crédito";
            this.btnTC.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(342, 362);
            this.Controls.Add(this.btnTC);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.btnPF);
            this.Controls.Add(this.btnCuentas);
            this.Controls.Add(this.lblTituloProductos);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloProductos;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnPF;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnTC;
    }
}