using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForms
{
    public partial class FormTest2 : Form
    {
        public FormTest2()
        {
            InitializeComponent();
        }

        private void FormTest2_Load(object sender, EventArgs e)
        {

        }

        private void btnCat_Click(object sender, EventArgs e)
        {

            if (this.btnCat.ImageIndex == 0)
            {

                MessageBox.Show("Buena suerte!", "Boton clickeado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.btnCat.ImageIndex = 1;
            }
            else 
            {
                MessageBox.Show("Mala suerte!", "Boton clickeado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                this.btnCat.ImageIndex = 0;
            }
        }
    }
}
