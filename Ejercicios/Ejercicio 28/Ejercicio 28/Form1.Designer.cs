namespace Ejercicio_28
{
    partial class Form1
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
            txtLienzo = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtLienzo
            // 
            txtLienzo.Location = new Point(0, 0);
            txtLienzo.Name = "txtLienzo";
            txtLienzo.Size = new Size(580, 400);
            txtLienzo.TabIndex = 0;
            txtLienzo.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcular.Location = new Point(445, 412);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(125, 29);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 453);
            Controls.Add(btnCalcular);
            Controls.Add(txtLienzo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contador de palabras";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox txtLienzo;
        private Button btnCalcular;
    }
}