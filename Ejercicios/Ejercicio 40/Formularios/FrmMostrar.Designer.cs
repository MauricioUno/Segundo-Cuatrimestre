namespace Formularios
{
    partial class FrmMostrar
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
            txtRecaudacion = new RichTextBox();
            btnSalir = new Button();
            txtGanancia = new TextBox();
            lblGanancia = new Label();
            SuspendLayout();
            // 
            // txtRecaudacion
            // 
            txtRecaudacion.Enabled = false;
            txtRecaudacion.Location = new Point(12, 12);
            txtRecaudacion.Name = "txtRecaudacion";
            txtRecaudacion.Size = new Size(460, 328);
            txtRecaudacion.TabIndex = 0;
            txtRecaudacion.Text = "";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(278, 384);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(192, 50);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtGanancia
            // 
            txtGanancia.Enabled = false;
            txtGanancia.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtGanancia.Location = new Point(12, 391);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new Size(201, 43);
            txtGanancia.TabIndex = 17;
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGanancia.Location = new Point(12, 360);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new Size(99, 28);
            lblGanancia.TabIndex = 18;
            lblGanancia.Text = "Ganancia";
            // 
            // FrmMostrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 453);
            Controls.Add(lblGanancia);
            Controls.Add(txtGanancia);
            Controls.Add(btnSalir);
            Controls.Add(txtRecaudacion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMostrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recaudación";
            Load += FrmMostrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtRecaudacion;
        private Button btnSalir;
        private TextBox txtGanancia;
        private Label lblGanancia;
    }
}