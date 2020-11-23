namespace EjBanco
{
    partial class frmCuentas
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
            this.lblLista = new System.Windows.Forms.Label();
            this.dataCuentas = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(166, 76);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(239, 29);
            this.lblLista.TabIndex = 2;
            this.lblLista.Text = "Listado de cuentas:";
            // 
            // dataCuentas
            // 
            this.dataCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCuentas.Location = new System.Drawing.Point(171, 108);
            this.dataCuentas.Name = "dataCuentas";
            this.dataCuentas.Size = new System.Drawing.Size(431, 242);
            this.dataCuentas.TabIndex = 3;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(27, 125);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(106, 36);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlta.Location = new System.Drawing.Point(27, 176);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(106, 35);
            this.btnAlta.TabIndex = 5;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(27, 318);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(106, 32);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "ATRAS";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // frmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(614, 362);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dataCuentas);
            this.Controls.Add(this.lblLista);
            this.Name = "frmCuentas";
            this.Text = "frmCuentas";
            this.Load += new System.EventHandler(this.frmCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCuentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dataCuentas;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnAtras;
    }
}