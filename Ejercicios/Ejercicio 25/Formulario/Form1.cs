using Entidades;
namespace Formulario
{
    public partial class FormDecBin : Form
    {
        public FormDecBin()
        {
            InitializeComponent();
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            if (this.txtDec.Text.IsInteger())
            {
                NumeroDecimal numero = this.txtDec.Text.ToInt();
                this.txtDecToBin.Text = ((NumeroBinario)numero).GetNumber();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtDec.Text = null;
                this.txtDecToBin.Text = null;
            }
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            if (this.txtBin.Text.IsBinary())
            {
                NumeroBinario numero = this.txtBin.Text;
                this.txtBinToDec.Text = ((NumeroDecimal)numero).GetNumber().ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtBin.Text = null;
                this.txtBinToDec.Text = null;
            }
        }
    }
}