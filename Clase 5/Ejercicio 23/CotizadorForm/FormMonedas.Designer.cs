namespace CotizadorForm
{
    partial class FormMonedas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMonedas));
            txtEuroAEuro = new TextBox();
            txtEuroADolar = new TextBox();
            txtEuroAPeso = new TextBox();
            txtDolarAPeso = new TextBox();
            txtDolarADolar = new TextBox();
            txtDolarAEuro = new TextBox();
            txtPesoAPeso = new TextBox();
            txtPesoADolar = new TextBox();
            txtPesoAEuro = new TextBox();
            btnConversorPeso = new Button();
            btnConversorDolar = new Button();
            btnConversorEuro = new Button();
            txtIngresoPeso = new TextBox();
            txtIngresoDolar = new TextBox();
            txtIngresoEuro = new TextBox();
            lblDolarIngreso = new Label();
            lblPesoIngreso = new Label();
            lblEuroIngreso = new Label();
            btnLock = new Button();
            Lock = new ImageList(components);
            txtCotzPeso = new TextBox();
            txtCotzDolar = new TextBox();
            txtCotzEuro = new TextBox();
            lblEuroSalida = new Label();
            lblDolarSalida = new Label();
            lblPesoSalida = new Label();
            lblCotizacion = new Label();
            SuspendLayout();
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Enabled = false;
            txtEuroAEuro.Location = new Point(381, 136);
            txtEuroAEuro.Margin = new Padding(4);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.Size = new Size(155, 31);
            txtEuroAEuro.TabIndex = 0;
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Enabled = false;
            txtEuroADolar.Location = new Point(545, 136);
            txtEuroADolar.Margin = new Padding(4);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.Size = new Size(155, 31);
            txtEuroADolar.TabIndex = 1;
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Enabled = false;
            txtEuroAPeso.Location = new Point(709, 136);
            txtEuroAPeso.Margin = new Padding(4);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.Size = new Size(155, 31);
            txtEuroAPeso.TabIndex = 2;
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Enabled = false;
            txtDolarAPeso.Location = new Point(709, 177);
            txtDolarAPeso.Margin = new Padding(4);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.Size = new Size(155, 31);
            txtDolarAPeso.TabIndex = 5;
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Enabled = false;
            txtDolarADolar.Location = new Point(545, 177);
            txtDolarADolar.Margin = new Padding(4);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.Size = new Size(155, 31);
            txtDolarADolar.TabIndex = 4;
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Enabled = false;
            txtDolarAEuro.Location = new Point(381, 177);
            txtDolarAEuro.Margin = new Padding(4);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.Size = new Size(155, 31);
            txtDolarAEuro.TabIndex = 3;
            // 
            // txtPesoAPeso
            // 
            txtPesoAPeso.Enabled = false;
            txtPesoAPeso.Location = new Point(709, 219);
            txtPesoAPeso.Margin = new Padding(4);
            txtPesoAPeso.Name = "txtPesoAPeso";
            txtPesoAPeso.Size = new Size(155, 31);
            txtPesoAPeso.TabIndex = 8;
            // 
            // txtPesoADolar
            // 
            txtPesoADolar.Enabled = false;
            txtPesoADolar.Location = new Point(545, 219);
            txtPesoADolar.Margin = new Padding(4);
            txtPesoADolar.Name = "txtPesoADolar";
            txtPesoADolar.Size = new Size(155, 31);
            txtPesoADolar.TabIndex = 7;
            // 
            // txtPesoAEuro
            // 
            txtPesoAEuro.Enabled = false;
            txtPesoAEuro.Location = new Point(381, 219);
            txtPesoAEuro.Margin = new Padding(4);
            txtPesoAEuro.Name = "txtPesoAEuro";
            txtPesoAEuro.Size = new Size(155, 31);
            txtPesoAEuro.TabIndex = 6;
            // 
            // btnConversorPeso
            // 
            btnConversorPeso.Location = new Point(256, 219);
            btnConversorPeso.Margin = new Padding(4);
            btnConversorPeso.Name = "btnConversorPeso";
            btnConversorPeso.Size = new Size(118, 34);
            btnConversorPeso.TabIndex = 9;
            btnConversorPeso.Text = "->";
            btnConversorPeso.UseVisualStyleBackColor = true;
            btnConversorPeso.Click += btnConversorPeso_Click;
            // 
            // btnConversorDolar
            // 
            btnConversorDolar.Location = new Point(256, 177);
            btnConversorDolar.Margin = new Padding(4);
            btnConversorDolar.Name = "btnConversorDolar";
            btnConversorDolar.Size = new Size(118, 34);
            btnConversorDolar.TabIndex = 10;
            btnConversorDolar.Text = "->";
            btnConversorDolar.UseVisualStyleBackColor = true;
            btnConversorDolar.Click += btnConversorDolar_Click;
            // 
            // btnConversorEuro
            // 
            btnConversorEuro.Location = new Point(256, 136);
            btnConversorEuro.Margin = new Padding(4);
            btnConversorEuro.Name = "btnConversorEuro";
            btnConversorEuro.Size = new Size(118, 34);
            btnConversorEuro.TabIndex = 11;
            btnConversorEuro.Text = "->";
            btnConversorEuro.UseVisualStyleBackColor = true;
            btnConversorEuro.Click += btnConversorEuro_Click;
            // 
            // txtIngresoPeso
            // 
            txtIngresoPeso.Location = new Point(92, 219);
            txtIngresoPeso.Margin = new Padding(4);
            txtIngresoPeso.Name = "txtIngresoPeso";
            txtIngresoPeso.Size = new Size(155, 31);
            txtIngresoPeso.TabIndex = 14;
            txtIngresoPeso.Leave += txtIngresoPeso_Leave;
            // 
            // txtIngresoDolar
            // 
            txtIngresoDolar.Location = new Point(92, 177);
            txtIngresoDolar.Margin = new Padding(4);
            txtIngresoDolar.Name = "txtIngresoDolar";
            txtIngresoDolar.Size = new Size(155, 31);
            txtIngresoDolar.TabIndex = 13;
            txtIngresoDolar.Leave += txtIngresoDolar_Leave;
            // 
            // txtIngresoEuro
            // 
            txtIngresoEuro.Location = new Point(92, 136);
            txtIngresoEuro.Margin = new Padding(4);
            txtIngresoEuro.Name = "txtIngresoEuro";
            txtIngresoEuro.Size = new Size(155, 31);
            txtIngresoEuro.TabIndex = 12;
            txtIngresoEuro.Leave += txtIngresoEuro_Leave;
            // 
            // lblDolarIngreso
            // 
            lblDolarIngreso.AutoSize = true;
            lblDolarIngreso.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolarIngreso.Location = new Point(28, 180);
            lblDolarIngreso.Margin = new Padding(4, 0, 4, 0);
            lblDolarIngreso.Name = "lblDolarIngreso";
            lblDolarIngreso.Size = new Size(61, 25);
            lblDolarIngreso.TabIndex = 16;
            lblDolarIngreso.Text = "Dólar";
            // 
            // lblPesoIngreso
            // 
            lblPesoIngreso.AutoSize = true;
            lblPesoIngreso.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPesoIngreso.Location = new Point(30, 222);
            lblPesoIngreso.Margin = new Padding(4, 0, 4, 0);
            lblPesoIngreso.Name = "lblPesoIngreso";
            lblPesoIngreso.Size = new Size(54, 25);
            lblPesoIngreso.TabIndex = 17;
            lblPesoIngreso.Text = "Peso";
            // 
            // lblEuroIngreso
            // 
            lblEuroIngreso.AutoSize = true;
            lblEuroIngreso.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuroIngreso.Location = new Point(28, 139);
            lblEuroIngreso.Margin = new Padding(4, 0, 4, 0);
            lblEuroIngreso.Name = "lblEuroIngreso";
            lblEuroIngreso.Size = new Size(52, 25);
            lblEuroIngreso.TabIndex = 18;
            lblEuroIngreso.Text = "Euro";
            // 
            // btnLock
            // 
            btnLock.ImageIndex = 0;
            btnLock.ImageList = Lock;
            btnLock.Location = new Point(256, 22);
            btnLock.Margin = new Padding(4);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(118, 40);
            btnLock.TabIndex = 22;
            btnLock.UseVisualStyleBackColor = true;
            btnLock.Click += btnLock_Click;
            // 
            // Lock
            // 
            Lock.ColorDepth = ColorDepth.Depth8Bit;
            Lock.ImageStream = (ImageListStreamer)resources.GetObject("Lock.ImageStream");
            Lock.TransparentColor = Color.Transparent;
            Lock.Images.SetKeyName(0, "Lock.png");
            Lock.Images.SetKeyName(1, "OpenLock.png");
            // 
            // txtCotzPeso
            // 
            txtCotzPeso.Enabled = false;
            txtCotzPeso.Location = new Point(709, 27);
            txtCotzPeso.Margin = new Padding(4);
            txtCotzPeso.Name = "txtCotzPeso";
            txtCotzPeso.Size = new Size(155, 31);
            txtCotzPeso.TabIndex = 21;
            txtCotzPeso.Leave += txtCotzPeso_Leave;
            // 
            // txtCotzDolar
            // 
            txtCotzDolar.Enabled = false;
            txtCotzDolar.Location = new Point(545, 27);
            txtCotzDolar.Margin = new Padding(4);
            txtCotzDolar.Name = "txtCotzDolar";
            txtCotzDolar.Size = new Size(155, 31);
            txtCotzDolar.TabIndex = 20;
            txtCotzDolar.Leave += txtCotzDolar_Leave;
            // 
            // txtCotzEuro
            // 
            txtCotzEuro.Enabled = false;
            txtCotzEuro.Location = new Point(381, 27);
            txtCotzEuro.Margin = new Padding(4);
            txtCotzEuro.Name = "txtCotzEuro";
            txtCotzEuro.Size = new Size(155, 31);
            txtCotzEuro.TabIndex = 19;
            txtCotzEuro.Leave += txtCotzEuro_Leave;
            // 
            // lblEuroSalida
            // 
            lblEuroSalida.AutoSize = true;
            lblEuroSalida.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuroSalida.Location = new Point(381, 107);
            lblEuroSalida.Margin = new Padding(4, 0, 4, 0);
            lblEuroSalida.Name = "lblEuroSalida";
            lblEuroSalida.Size = new Size(52, 25);
            lblEuroSalida.TabIndex = 23;
            lblEuroSalida.Text = "Euro";
            // 
            // lblDolarSalida
            // 
            lblDolarSalida.AutoSize = true;
            lblDolarSalida.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolarSalida.Location = new Point(545, 107);
            lblDolarSalida.Margin = new Padding(4, 0, 4, 0);
            lblDolarSalida.Name = "lblDolarSalida";
            lblDolarSalida.Size = new Size(61, 25);
            lblDolarSalida.TabIndex = 24;
            lblDolarSalida.Text = "Dólar";
            // 
            // lblPesoSalida
            // 
            lblPesoSalida.AutoSize = true;
            lblPesoSalida.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPesoSalida.Location = new Point(709, 107);
            lblPesoSalida.Margin = new Padding(4, 0, 4, 0);
            lblPesoSalida.Name = "lblPesoSalida";
            lblPesoSalida.Size = new Size(54, 25);
            lblPesoSalida.TabIndex = 25;
            lblPesoSalida.Text = "Peso";
            // 
            // lblCotizacion
            // 
            lblCotizacion.AutoSize = true;
            lblCotizacion.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCotizacion.Location = new Point(147, 32);
            lblCotizacion.Margin = new Padding(4, 0, 4, 0);
            lblCotizacion.Name = "lblCotizacion";
            lblCotizacion.Size = new Size(104, 25);
            lblCotizacion.TabIndex = 26;
            lblCotizacion.Text = "Cotización";
            // 
            // FormMonedas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 263);
            Controls.Add(lblCotizacion);
            Controls.Add(lblPesoSalida);
            Controls.Add(lblDolarSalida);
            Controls.Add(lblEuroSalida);
            Controls.Add(btnLock);
            Controls.Add(txtCotzPeso);
            Controls.Add(txtCotzDolar);
            Controls.Add(txtCotzEuro);
            Controls.Add(lblEuroIngreso);
            Controls.Add(lblPesoIngreso);
            Controls.Add(lblDolarIngreso);
            Controls.Add(txtIngresoPeso);
            Controls.Add(txtIngresoDolar);
            Controls.Add(txtIngresoEuro);
            Controls.Add(btnConversorEuro);
            Controls.Add(btnConversorDolar);
            Controls.Add(btnConversorPeso);
            Controls.Add(txtPesoAPeso);
            Controls.Add(txtPesoADolar);
            Controls.Add(txtPesoAEuro);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtDolarAEuro);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtEuroAEuro);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMonedas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEuroAEuro;
        private TextBox txtEuroADolar;
        private TextBox txtEuroAPeso;
        private TextBox txtDolarAPeso;
        private TextBox txtDolarADolar;
        private TextBox txtDolarAEuro;
        private TextBox txtPesoAPeso;
        private TextBox txtPesoADolar;
        private TextBox txtPesoAEuro;
        private Button btnConversorPeso;
        private Button btnConversorDolar;
        private Button btnConversorEuro;
        private TextBox txtIngresoPeso;
        private TextBox txtIngresoDolar;
        private TextBox txtIngresoEuro;
        private Label lblDolarIngreso;
        private Label lblPesoIngreso;
        private Label lblEuroIngreso;
        private Button btnLock;
        private TextBox txtCotzPeso;
        private TextBox txtCotzDolar;
        private TextBox txtCotzEuro;
        private Label lblEuroSalida;
        private Label lblDolarSalida;
        private Label lblPesoSalida;
        private Label lblCotizacion;
        private ImageList Lock;
    }
}