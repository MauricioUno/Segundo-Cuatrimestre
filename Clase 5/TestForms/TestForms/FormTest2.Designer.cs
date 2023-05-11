namespace TestForms
{
    partial class FormTest2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest2));
            btnCat = new Button();
            Gatos = new ImageList(components);
            SuspendLayout();
            // 
            // btnCat
            // 
            btnCat.ImageIndex = 0;
            btnCat.ImageList = Gatos;
            btnCat.Location = new Point(165, 100);
            btnCat.Name = "btnCat";
            btnCat.Size = new Size(70, 70);
            btnCat.TabIndex = 0;
            btnCat.UseVisualStyleBackColor = true;
            btnCat.Click += btnCat_Click;
            // 
            // Gatos
            // 
            Gatos.ColorDepth = ColorDepth.Depth8Bit;
            Gatos.ImageStream = (ImageListStreamer)resources.GetObject("Gatos.ImageStream");
            Gatos.TransparentColor = Color.Transparent;
            Gatos.Images.SetKeyName(0, "LuckCat.png");
            Gatos.Images.SetKeyName(1, "TrashCat.png");
            // 
            // FormTest2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 203);
            Controls.Add(btnCat);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTest2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Segundo Formulario";
            Load += FormTest2_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCat;
        private ImageList Gatos;
    }
}