namespace TestForms
{
    partial class FormTest
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
            btnNombreApellido = new Button();
            txtNombre = new TextBox();
            lblName = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            btnForm = new Button();
            SuspendLayout();
            // 
            // btnNombreApellido
            // 
            btnNombreApellido.Font = new Font("Jingle Balons GT Demo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNombreApellido.Location = new Point(51, 94);
            btnNombreApellido.Name = "btnNombreApellido";
            btnNombreApellido.Size = new Size(200, 75);
            btnNombreApellido.TabIndex = 0;
            btnNombreApellido.Text = "Nombre y apellido";
            btnNombreApellido.UseVisualStyleBackColor = true;
            btnNombreApellido.Click += btnNombreApellido_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txt1_TextChanged;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 17);
            lblName.Name = "lblName";
            lblName.Size = new Size(64, 20);
            lblName.TabIndex = 2;
            lblName.Text = "Nombre";
            lblName.Click += label1_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(167, 17);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            lblApellido.Click += label2_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(167, 40);
            txtApellido.Name = "txtApellido";
            txtApellido.PlaceholderText = "Apellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 3;
            txtApellido.TextChanged += textBox1_TextChanged;
            // 
            // btnForm
            // 
            btnForm.Font = new Font("Jingle Balons GT Demo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnForm.Location = new Point(300, 350);
            btnForm.Name = "btnForm";
            btnForm.Size = new Size(200, 75);
            btnForm.TabIndex = 5;
            btnForm.Text = "Abrir segundo formulario";
            btnForm.UseVisualStyleBackColor = true;
            btnForm.Click += btnSegundoForm_Click;
            // 
            // FormTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(btnForm);
            Controls.Add(lblApellido);
            Controls.Add(txtApellido);
            Controls.Add(lblName);
            Controls.Add(txtNombre);
            Controls.Add(btnNombreApellido);
            IsMdiContainer = true;
            Name = "FormTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forms Test";
            FormClosing += FormTest_FormClosing;
            Load += FormTest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNombreApellido;
        private TextBox txtNombre;
        private Label lblName;
        private Label lblApellido;
        private TextBox txtApellido;
        private Button btnForm;
    }
}