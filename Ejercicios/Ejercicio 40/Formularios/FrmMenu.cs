using Entidades.Clases;

namespace Formularios
{
    public partial class FrmMenu : Form
    {
        private Centralita centralTelefonica;
        public FrmMenu(Centralita central)
        {
            InitializeComponent();
            this.centralTelefonica = central;
    }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frm = new FrmLlamador(this.centralTelefonica);
            frm.ShowDialog();
            this.centralTelefonica = frm.CentralTelefonica;
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar form = new FrmMostrar(this.centralTelefonica);
            form.TipoLlamada = EtipoLLamada.Todas;
            form.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar form = new FrmMostrar(this.centralTelefonica);
            form.TipoLlamada = EtipoLLamada.Local;
            form.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar form = new FrmMostrar(this.centralTelefonica);
            form.TipoLlamada = EtipoLLamada.Provincial;
            form.ShowDialog();
        }
    }
}