namespace AppAgendaTelefonica22
{
    partial class FrmAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtgAgenda = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirección = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 29);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar contacto...";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(797, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dtgAgenda
            // 
            this.dtgAgenda.AllowUserToAddRows = false;
            this.dtgAgenda.AllowUserToDeleteRows = false;
            this.dtgAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.dirección,
            this.teléfono,
            this.tipoTel});
            this.dtgAgenda.Location = new System.Drawing.Point(12, 47);
            this.dtgAgenda.Name = "dtgAgenda";
            this.dtgAgenda.ReadOnly = true;
            this.dtgAgenda.RowHeadersWidth = 51;
            this.dtgAgenda.RowTemplate.Height = 29;
            this.dtgAgenda.Size = new System.Drawing.Size(879, 391);
            this.dtgAgenda.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 250;
            // 
            // dirección
            // 
            this.dirección.DataPropertyName = "Dirección";
            this.dirección.HeaderText = "Dirección";
            this.dirección.MinimumWidth = 6;
            this.dirección.Name = "dirección";
            this.dirección.ReadOnly = true;
            this.dirección.Width = 250;
            // 
            // teléfono
            // 
            this.teléfono.DataPropertyName = "Teléfono";
            this.teléfono.HeaderText = "Número de teléfono";
            this.teléfono.MinimumWidth = 6;
            this.teléfono.Name = "teléfono";
            this.teléfono.ReadOnly = true;
            this.teléfono.Width = 200;
            // 
            // tipoTel
            // 
            this.tipoTel.DataPropertyName = "TipoDeTeléfono";
            this.tipoTel.HeaderText = "Tipo de teléfono";
            this.tipoTel.MinimumWidth = 6;
            this.tipoTel.Name = "tipoTel";
            this.tipoTel.ReadOnly = true;
            this.tipoTel.Width = 125;
            // 
            // FrmAgenda
            // 
            this.AcceptButton = this.btnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.dtgAgenda);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgenda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAgregar;
        private Button btnSalir;
        private DataGridView dtgAgenda;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn dirección;
        private DataGridViewTextBoxColumn teléfono;
        private DataGridViewTextBoxColumn tipoTel;
    }
}