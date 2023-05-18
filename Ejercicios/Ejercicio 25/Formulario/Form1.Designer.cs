namespace Formulario
{
    partial class FormDecBin
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
            txtDecToBin = new TextBox();
            lblDecToBin = new Label();
            btnDecToBin = new Button();
            txtDec = new TextBox();
            txtBin = new TextBox();
            btnBinToDec = new Button();
            txtBinToDec = new TextBox();
            lblBinToDec = new Label();
            SuspendLayout();
            // 
            // txtDecToBin
            // 
            txtDecToBin.Enabled = false;
            txtDecToBin.Location = new Point(415, 48);
            txtDecToBin.Name = "txtDecToBin";
            txtDecToBin.Size = new Size(125, 27);
            txtDecToBin.TabIndex = 0;
            // 
            // lblDecToBin
            // 
            lblDecToBin.AutoSize = true;
            lblDecToBin.Location = new Point(51, 51);
            lblDecToBin.Name = "lblDecToBin";
            lblDecToBin.Size = new Size(127, 20);
            lblDecToBin.TabIndex = 1;
            lblDecToBin.Text = "Decimal a Binario";
            // 
            // btnDecToBin
            // 
            btnDecToBin.Location = new Point(315, 47);
            btnDecToBin.Name = "btnDecToBin";
            btnDecToBin.Size = new Size(94, 29);
            btnDecToBin.TabIndex = 2;
            btnDecToBin.Text = "-->";
            btnDecToBin.UseVisualStyleBackColor = true;
            btnDecToBin.Click += btnDecToBin_Click;
            // 
            // txtDec
            // 
            txtDec.Location = new Point(184, 48);
            txtDec.Name = "txtDec";
            txtDec.Size = new Size(125, 27);
            txtDec.TabIndex = 3;
            // 
            // txtBin
            // 
            txtBin.Location = new Point(184, 81);
            txtBin.Name = "txtBin";
            txtBin.Size = new Size(125, 27);
            txtBin.TabIndex = 6;
            // 
            // btnBinToDec
            // 
            btnBinToDec.Location = new Point(315, 80);
            btnBinToDec.Name = "btnBinToDec";
            btnBinToDec.Size = new Size(94, 29);
            btnBinToDec.TabIndex = 5;
            btnBinToDec.Text = "-->";
            btnBinToDec.UseVisualStyleBackColor = true;
            btnBinToDec.Click += btnBinToDec_Click;
            // 
            // txtBinToDec
            // 
            txtBinToDec.Enabled = false;
            txtBinToDec.Location = new Point(415, 82);
            txtBinToDec.Name = "txtBinToDec";
            txtBinToDec.Size = new Size(125, 27);
            txtBinToDec.TabIndex = 4;
            // 
            // lblBinToDec
            // 
            lblBinToDec.AutoSize = true;
            lblBinToDec.Location = new Point(51, 84);
            lblBinToDec.Name = "lblBinToDec";
            lblBinToDec.Size = new Size(127, 20);
            lblBinToDec.TabIndex = 7;
            lblBinToDec.Text = "Binario a Decimal";
            // 
            // FormDecBin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 153);
            Controls.Add(lblBinToDec);
            Controls.Add(txtBin);
            Controls.Add(btnBinToDec);
            Controls.Add(txtBinToDec);
            Controls.Add(txtDec);
            Controls.Add(btnDecToBin);
            Controls.Add(lblDecToBin);
            Controls.Add(txtDecToBin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDecBin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor Decimal-Binario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDecToBin;
        private Label lblDecToBin;
        private Button btnDecToBin;
        private TextBox txtDec;
        private TextBox txtBin;
        private Button btnBinToDec;
        private TextBox txtBinToDec;
        private Label lblBinToDec;
    }
}