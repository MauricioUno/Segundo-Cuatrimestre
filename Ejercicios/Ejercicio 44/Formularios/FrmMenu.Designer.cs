namespace Formularios
{
    partial class FrmMenu
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
            btnGenerarLlamada = new Button();
            btnFacturacionTotal = new Button();
            btnFacturacionLocal = new Button();
            btnFacturacionProvincial = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            btnGenerarLlamada.Location = new Point(10, 12);
            btnGenerarLlamada.Name = "btnGenerarLlamada";
            btnGenerarLlamada.Size = new Size(310, 65);
            btnGenerarLlamada.TabIndex = 0;
            btnGenerarLlamada.Text = "Generar Llamada";
            btnGenerarLlamada.UseVisualStyleBackColor = true;
            btnGenerarLlamada.Click += btnGenerarLlamada_Click;
            // 
            // btnFacturacionTotal
            // 
            btnFacturacionTotal.Location = new Point(10, 83);
            btnFacturacionTotal.Name = "btnFacturacionTotal";
            btnFacturacionTotal.Size = new Size(310, 65);
            btnFacturacionTotal.TabIndex = 1;
            btnFacturacionTotal.Text = "Facturación Total";
            btnFacturacionTotal.UseVisualStyleBackColor = true;
            btnFacturacionTotal.Click += btnFacturacionTotal_Click;
            // 
            // btnFacturacionLocal
            // 
            btnFacturacionLocal.Location = new Point(10, 154);
            btnFacturacionLocal.Name = "btnFacturacionLocal";
            btnFacturacionLocal.Size = new Size(310, 65);
            btnFacturacionLocal.TabIndex = 2;
            btnFacturacionLocal.Text = "Facturación Local";
            btnFacturacionLocal.UseVisualStyleBackColor = true;
            btnFacturacionLocal.Click += btnFacturacionLocal_Click;
            // 
            // btnFacturacionProvincial
            // 
            btnFacturacionProvincial.Location = new Point(10, 225);
            btnFacturacionProvincial.Name = "btnFacturacionProvincial";
            btnFacturacionProvincial.Size = new Size(310, 65);
            btnFacturacionProvincial.TabIndex = 3;
            btnFacturacionProvincial.Text = "Facturación Provincial";
            btnFacturacionProvincial.UseVisualStyleBackColor = true;
            btnFacturacionProvincial.Click += btnFacturacionProvincial_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 296);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(310, 65);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 373);
            Controls.Add(btnSalir);
            Controls.Add(btnFacturacionProvincial);
            Controls.Add(btnFacturacionLocal);
            Controls.Add(btnFacturacionTotal);
            Controls.Add(btnGenerarLlamada);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Central Telefónica";
            Load += FrmMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerarLlamada;
        private Button btnFacturacionTotal;
        private Button btnFacturacionLocal;
        private Button btnFacturacionProvincial;
        private Button btnSalir;
    }
}