using Entidades.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmMostrar : Form
    {
        private Centralita centralTelefonica;
        private EtipoLLamada tipoLlamada;

        public EtipoLLamada TipoLlamada
        {
            set
            {
                this.tipoLlamada = value;
            }
        }

        public FrmMostrar(Centralita central)
        {
            InitializeComponent();
            this.centralTelefonica = central;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            this.centralTelefonica.OrdenarLlamadas();
            List<Llamada> listaLocal = new List<Llamada>();
            List<Llamada> listaProvincial = new List<Llamada>();
            List<Llamada> listaBackUp = new List<Llamada>();

            foreach (Llamada llamada in this.centralTelefonica.Llamadas) 
            {
                if (llamada is Local) 
                {
                    listaLocal.Add(llamada);
                }
                else if(llamada is Provincial)
                {
                    listaProvincial.Add(llamada);
                }
            }
            switch (this.tipoLlamada)
            {
                case EtipoLLamada.Local:
                    this.Text = "Recaudación Local";
                    this.txtGanancia.Text = this.centralTelefonica.GananciaPorLocal.ToString("F2");
                    this.centralTelefonica.Llamadas.RemoveAll(llamada => llamada is not Local);
                    listaBackUp = listaProvincial;
                    break;
                case EtipoLLamada.Provincial:
                    this.Text = "Recaudación Provincial";
                    this.txtGanancia.Text = this.centralTelefonica.GananciaPorProvincial.ToString("F2");
                    this.centralTelefonica.Llamadas.RemoveAll(llamada => llamada is not Provincial);
                    listaBackUp = listaLocal;
                    break;
                default:
                    this.Text = "Recaudación Total";
                    this.txtGanancia.Text = this.centralTelefonica.GananciaPorTotal.ToString("F2");
                    break;
            }
            this.txtRecaudacion.Text = this.centralTelefonica.ToString();
            foreach (Llamada llamada in listaBackUp) 
            {
                this.centralTelefonica.Llamadas.Add(llamada);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
