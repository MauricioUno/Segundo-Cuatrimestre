using Billetes;
using Entidades;

namespace CotizadorForm
{
    public partial class FormMonedas : Form
    {
        private Euro auxEuro = 0;
        private Dolar auxDolar = 0;
        private Peso auxPeso = 0;
        private TextBox[] ConversoresEuro = new TextBox[4];
        private TextBox[] ConversoresDolar = new TextBox[4];
        private TextBox[] ConversoresPeso = new TextBox[4];
        public FormMonedas()
        {
            InitializeComponent();
            this.txtCotzEuro.Text = Euro.GetCotizacion().ToString();
            this.txtCotzDolar.Text = Dolar.GetCotizacion().ToString();
            this.txtCotzPeso.Text = Peso.GetCotizacion().ToString();

            this.ConversoresEuro[0] = this.txtEuroAEuro;
            this.ConversoresEuro[1] = this.txtEuroADolar;
            this.ConversoresEuro[2] = this.txtEuroAPeso;
            this.ConversoresEuro[3] = this.txtIngresoEuro;

            this.ConversoresDolar[0] = this.txtDolarAEuro;
            this.ConversoresDolar[1] = this.txtDolarADolar;
            this.ConversoresDolar[2] = this.txtDolarAPeso;
            this.ConversoresDolar[3] = this.txtIngresoDolar;

            this.ConversoresPeso[0] = this.txtPesoAEuro;
            this.ConversoresPeso[1] = this.txtPesoADolar;
            this.ConversoresPeso[2] = this.txtPesoAPeso;
            this.ConversoresPeso[3] = this.txtIngresoPeso;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (this.btnLock.ImageIndex == 0)
            {
                this.btnLock.ImageIndex = 1;
                changeStateCotz(true);
            }
            else if (this.btnLock.ImageIndex == 1)
            {
                this.btnLock.ImageIndex = 0;
                changeStateCotz(false);
                this.RealizarConversionTextBoxes(this.auxEuro);
                this.RealizarConversionTextBoxes(this.auxPeso);
            }
        }

        private void changeStateCotz(bool state)
        {
            this.txtCotzDolar.Enabled = state;
            this.txtCotzEuro.Enabled = state;
            this.txtCotzPeso.Enabled = state;
            this.btnConversorDolar.Enabled = !state;
            this.btnConversorEuro.Enabled = !state;
            this.btnConversorPeso.Enabled = !state;
            this.txtIngresoEuro.Enabled = !state;
            this.txtIngresoDolar.Enabled = !state;
            this.txtIngresoPeso.Enabled = !state;
        }


        private void btnConversorEuro_Click(object sender, EventArgs e)
        {
            this.RealizarConversionTextBoxes(this.auxEuro);
        }

        private void btnConversorDolar_Click(object sender, EventArgs e)
        {
            this.RealizarConversionTextBoxes(this.auxDolar);
        }

        private void btnConversorPeso_Click(object sender, EventArgs e)
        {
            this.RealizarConversionTextBoxes(this.auxPeso);
        }


        private void RealizarConversionTextBoxes(Euro moneda)
        {
            if (Validaciones.StringIsPositive(this.ConversoresEuro[3].Text))
            {
                moneda = Validaciones.StringToDouble(this.ConversoresEuro[3].Text);
                this.ConversoresEuro[0].Text = (moneda).GetCantidad().ToString("F2");
                this.ConversoresEuro[1].Text = ((Dolar)moneda).GetCantidad().ToString("F2");
                this.ConversoresEuro[2].Text = ((Peso)moneda).GetCantidad().ToString("F2");
            }
            else
            {
                this.ResetearTextBoxes(this.ConversoresEuro);
            }
        }

        private void RealizarConversionTextBoxes(Dolar moneda)
        {
            if (Validaciones.StringIsPositive(this.ConversoresDolar[3].Text))
            {
                moneda = Validaciones.StringToDouble(this.ConversoresDolar[3].Text);
                this.ConversoresDolar[0].Text = ((Euro)moneda).GetCantidad().ToString("F2");
                this.ConversoresDolar[1].Text = (moneda).GetCantidad().ToString("F2");
                this.ConversoresDolar[2].Text = ((Peso)moneda).GetCantidad().ToString("F2");
            }
            else
            {
                this.ResetearTextBoxes(this.ConversoresDolar);
            }

        }

        private void RealizarConversionTextBoxes(Peso moneda)
        {
            if (Validaciones.StringIsPositive(this.ConversoresPeso[3].Text))
            {
                moneda = Validaciones.StringToDouble(this.ConversoresPeso[3].Text);
                this.ConversoresPeso[0].Text = ((Euro)moneda).GetCantidad().ToString("F2");
                this.ConversoresPeso[1].Text = ((Dolar)moneda).GetCantidad().ToString("F2");
                this.ConversoresPeso[2].Text = (moneda).GetCantidad().ToString("F2");
            }
            else
            {
                this.ResetearTextBoxes(this.ConversoresPeso);
            }

        }
        private void ResetearTextBoxes(TextBox[] listaTextBoxes)
        {
            foreach (TextBox textBox in listaTextBoxes)
            {
                this.AsignarValorATextBox(textBox, "");
            }
        }
            
        private void AsignarValorATextBox(TextBox caja, string texto)
        {
            caja.Text = texto;
        }

        private void txtCotzEuro_Leave(object sender, EventArgs e)
        {
            if (Validaciones.StringIsPositive(this.txtCotzEuro.Text))
            {
                Euro.SetCotizacion(Validaciones.StringToDouble(this.txtCotzEuro.Text));
            }
            else
            {
                AsignarValorATextBox(this.txtCotzEuro, Euro.GetCotizacion().ToString());
            }


        }

        private void txtCotzDolar_Leave(object sender, EventArgs e)
        {
            AsignarValorATextBox(this.txtCotzDolar, Dolar.GetCotizacion().ToString());
        }

        private void txtCotzPeso_Leave(object sender, EventArgs e)
        {
            if (Validaciones.StringIsPositive(this.txtCotzPeso.Text))
            {
                Peso.SetCotizacion(Validaciones.StringToDouble(this.txtCotzPeso.Text));
            }
            else
            {
                AsignarValorATextBox(this.txtCotzPeso, Peso.GetCotizacion().ToString());
            }

        }

        private void txtIngresoEuro_Leave(object sender, EventArgs e)
        {
            RealizarConversionTextBoxes(this.auxEuro);
        }

        private void txtIngresoDolar_Leave(object sender, EventArgs e)
        {
            RealizarConversionTextBoxes(this.auxDolar);
        }

        private void txtIngresoPeso_Leave(object sender, EventArgs e)
        {
            RealizarConversionTextBoxes(this.auxPeso);
        }
    }
}