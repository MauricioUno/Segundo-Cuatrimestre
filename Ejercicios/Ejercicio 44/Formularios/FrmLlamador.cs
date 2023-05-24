using Entidades.Clases;
using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmLlamador : Form
    {
        private Centralita centralTelefonica;

        public Centralita CentralTelefonica
        {
            get
            {
                return this.centralTelefonica;
            }
        }
        public FrmLlamador(Centralita central)
        {
            InitializeComponent();
            this.centralTelefonica = central;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(EFranja));
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "-";
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text += "#";
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(this.txtNroDestino.Text, "^#?[0-9]{4}-[0-9]{4}$") && Regex.IsMatch(this.txtNroOrigen.Text, "^[0-9]{4}-[0-9]{4}$"))
            {
                Llamada nuevaLlamada;
                if (Regex.IsMatch(this.txtNroDestino.Text, "^#"))
                {
                    EFranja franjas;
                    Enum.TryParse(this.cmbFranja.SelectedValue.ToString(), out franjas);
                    nuevaLlamada = new Provincial(this.txtNroOrigen.Text, franjas, new Random().Next(1, 50), this.txtNroDestino.Text);
                    
                }
                else
                {
                    float costo;
                    costo = new Random().Next(5, 56) / (float)10;
                    nuevaLlamada = new Local(this.txtNroOrigen.Text, new Random().Next(1, 50), this.txtNroDestino.Text, costo);
                }
                try
                {
                    this.centralTelefonica += nuevaLlamada;
                }
                catch(CentralitaException ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Nro. Destino o Nro.Origen Invalidos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "";
            this.txtNroOrigen.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNroDestino_TextChanged(object sender, EventArgs e)
        {
            this.cmbFranja.Enabled = Regex.IsMatch(this.txtNroDestino.Text, "^#");
        }
    }
}
