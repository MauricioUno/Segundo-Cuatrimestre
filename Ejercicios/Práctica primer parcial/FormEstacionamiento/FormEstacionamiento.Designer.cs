namespace FormEstacionamiento
{
    partial class FormEstacionamiento
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
            components = new System.ComponentModel.Container();
            btnAgregar = new Button();
            cmbTipoVehiculo = new ComboBox();
            cmbTipoMoto = new ComboBox();
            txtPatente = new TextBox();
            txtMarca = new TextBox();
            lblTipoVehiculo = new Label();
            lblTipo = new Label();
            lstVehiculos = new ListBox();
            txtNombreEstacionamiento = new TextBox();
            lblPatente = new Label();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(169, 209);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(207, 88);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar Vehiculo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(169, 32);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(151, 28);
            cmbTipoVehiculo.TabIndex = 1;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(169, 142);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(151, 28);
            cmbTipoMoto.TabIndex = 2;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(169, 85);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(151, 27);
            txtPatente.TabIndex = 3;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(169, 143);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(151, 27);
            txtMarca.TabIndex = 4;
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(44, 35);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(122, 20);
            lblTipoVehiculo.TabIndex = 5;
            lblTipoVehiculo.Text = "Tipo de vehiculo:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(81, 146);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(82, 20);
            lblTipo.TabIndex = 6;
            lblTipo.Text = "Tipo moto:";
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalExtent = 100;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ImeMode = ImeMode.NoControl;
            lstVehiculos.ItemHeight = 20;
            lstVehiculos.Location = new Point(396, 100);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.ScrollAlwaysVisible = true;
            lstVehiculos.Size = new Size(574, 344);
            lstVehiculos.TabIndex = 7;
            lstVehiculos.MouseDoubleClick += lstVehiculos_MouseDoubleClick;
            // 
            // txtNombreEstacionamiento
            // 
            txtNombreEstacionamiento.Enabled = false;
            txtNombreEstacionamiento.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreEstacionamiento.Location = new Point(396, 12);
            txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            txtNombreEstacionamiento.Size = new Size(574, 61);
            txtNombreEstacionamiento.TabIndex = 8;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(102, 88);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(61, 20);
            lblPatente.TabIndex = 9;
            lblPatente.Text = "Patente:";
            // 
            // FormEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(lblPatente);
            Controls.Add(txtNombreEstacionamiento);
            Controls.Add(lstVehiculos);
            Controls.Add(lblTipo);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(txtMarca);
            Controls.Add(txtPatente);
            Controls.Add(cmbTipoMoto);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(btnAgregar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEstacionamiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estacionamiento";
            Load += FormEstacionamiento_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private ComboBox cmbTipoVehiculo;
        private ComboBox cmbTipoMoto;
        private TextBox txtPatente;
        private TextBox txtMarca;
        private Label lblTipoVehiculo;
        private Label lblTipo;
        private ListBox lstVehiculos;
        private TextBox txtNombreEstacionamiento;
        private Label lblPatente;
        private BindingSource bindingSource1;
    }
}