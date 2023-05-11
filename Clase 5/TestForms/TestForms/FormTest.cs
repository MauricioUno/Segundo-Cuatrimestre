namespace TestForms
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {

        }

        private void btnNombreApellido_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{this.txtNombre.Text} {this.txtApellido.Text}", "Contenido Cajas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSegundoForm_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Abrir Segundo Form?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                FormTest2 segundoForm = new FormTest2();
                segundoForm.MdiParent = this;
                segundoForm.Show();
            }


        }

        private void FormTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult respuesta = MessageBox.Show("Cerrar formulario?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


    }
}