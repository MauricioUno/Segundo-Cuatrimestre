using Entidades;
using System.Drawing;

namespace Formulario
{
    public partial class FormEscalas : Form
    {
        public FormEscalas()
        {
            InitializeComponent();
        }

        private void btnConvertirCelcius_Click(object sender, EventArgs e)
        {

            if (this.txtCelcius.Text.IsNumber())
            {
                Celcius gradoCelcius = new Celcius(this.txtCelcius.Text.ToDouble());
                this.txtCelciusToCelcius.Text = gradoCelcius.GetCantidad().ToString("F2");
                this.txtCelciusToFahrenheit.Text = ((Fahrenheit)gradoCelcius).GetCantidad().ToString("F2");
                this.txtCelciusToKelvin.Text = ((Kelvin)gradoCelcius).GetCantidad().ToString("F2");
            }
        }

        private void btnConvertirFahrenheit_Click(object sender, EventArgs e)
        {
            if (this.txtFahrenheit.Text.IsNumber())
            {
                Fahrenheit gradoFarenheit = new Fahrenheit(this.txtFahrenheit.Text.ToDouble());
                this.txtFahrenheitToCelcius.Text = ((Celcius)gradoFarenheit).GetCantidad().ToString("F2");
                this.txtFahrenheitToFahrenheit.Text = gradoFarenheit.GetCantidad().ToString("F2");
                this.txtFahrenheitToKelvin.Text = ((Kelvin)gradoFarenheit).GetCantidad().ToString("F2");
            }
        }
        private void btnConvertirKelvin_Click(object sender, EventArgs e)
        {
            if (this.txtKelvin.Text.IsNumber())
            {
                Kelvin gradoKelvin = new Kelvin(this.txtKelvin.Text.ToDouble());
                this.txtKelvinToCelcius.Text = ((Celcius)gradoKelvin).GetCantidad().ToString("F2");
                this.txtKelvinToFahrenheit.Text = ((Fahrenheit)gradoKelvin).GetCantidad().ToString("F2");
                this.txtKelvinToKelvin.Text = gradoKelvin.GetCantidad().ToString("F2");
            }
        }

        private void FormEscalas_Load(object sender, EventArgs e)
        {

        }
    }
}