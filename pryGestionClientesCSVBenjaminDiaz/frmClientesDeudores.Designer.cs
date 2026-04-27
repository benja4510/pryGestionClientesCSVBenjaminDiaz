namespace pryGestionClientesCSVBenjaminDiaz
{
    partial class frmClientesDeudores
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
            this.gboConsultaDatos = new System.Windows.Forms.GroupBox();
            this.lblPromedioDeuda = new System.Windows.Forms.Label();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboConsultaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gboConsultaDatos
            // 
            this.gboConsultaDatos.Controls.Add(this.lblPromedioDeuda);
            this.gboConsultaDatos.Controls.Add(this.lblCantidadClientes);
            this.gboConsultaDatos.Controls.Add(this.lblTotalDeuda);
            this.gboConsultaDatos.Controls.Add(this.dgvDatos);
            this.gboConsultaDatos.Location = new System.Drawing.Point(48, -21);
            this.gboConsultaDatos.Name = "gboConsultaDatos";
            this.gboConsultaDatos.Size = new System.Drawing.Size(463, 493);
            this.gboConsultaDatos.TabIndex = 2;
            this.gboConsultaDatos.TabStop = false;
            this.gboConsultaDatos.Text = "Consulta de Datos";
            // 
            // lblPromedioDeuda
            // 
            this.lblPromedioDeuda.AutoSize = true;
            this.lblPromedioDeuda.Location = new System.Drawing.Point(332, 442);
            this.lblPromedioDeuda.Name = "lblPromedioDeuda";
            this.lblPromedioDeuda.Size = new System.Drawing.Size(104, 13);
            this.lblPromedioDeuda.TabIndex = 3;
            this.lblPromedioDeuda.Text = "Promedio de Deuda:";
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.Location = new System.Drawing.Point(332, 399);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(107, 13);
            this.lblCantidadClientes.TabIndex = 2;
            this.lblCantidadClientes.Text = "Cantidad de Clientes:";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Location = new System.Drawing.Point(332, 352);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(84, 13);
            this.lblTotalDeuda.TabIndex = 1;
            this.lblTotalDeuda.Text = "Total de Deuda:";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDatos.Location = new System.Drawing.Point(6, 33);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(429, 301);
            this.dgvDatos.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Limite de Credito";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Deuda";
            this.Column4.Name = "Column4";
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 478);
            this.Controls.Add(this.gboConsultaDatos);
            this.Name = "frmClientesDeudores";
            this.Text = "frmClientesDeudores";
            this.Load += new System.EventHandler(this.frmClientesDeudores_Load);
            this.gboConsultaDatos.ResumeLayout(false);
            this.gboConsultaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboConsultaDatos;
        private System.Windows.Forms.Label lblPromedioDeuda;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}