using Entidades;
using System.Windows.Forms;

namespace Uño.Mauricio._2C
{
    public partial class View : Form
    {
        private Persona alumno;
        private Persona profesorProgra;
        private Curso cursoProgramacion;
        private Persona profesorLabo;
        private Curso cursoLaboratorio;
        public View()
        {
            InitializeComponent();
            profesorLabo = new Profesor(99000123, "profesorLabo@email.com", EMateria.Laboratorio);
            profesorProgra = new Profesor(99000123, "profesorProgra @email.com", EMateria.Programacion);
            cursoProgramacion = new Curso((Profesor)profesorProgra);
            cursoLaboratorio = new Curso((Profesor)profesorLabo);
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (lstAlumnosCreados.SelectedIndex != -1)
            {
                EMateria materia = (EMateria)this.cmbMaterias.SelectedItem;
                string mensaje = string.Empty;
                if (materia == EMateria.Programacion)
                {
                    mensaje = cursoProgramacion.InscribirAlumno((Alumno)lstAlumnosCreados.Items[lstAlumnosCreados.SelectedIndex]);
                }
                else
                {
                    mensaje = cursoLaboratorio.InscribirAlumno((Alumno)lstAlumnosCreados.Items[lstAlumnosCreados.SelectedIndex]);
                }
                MessageBox.Show(mensaje, "Incripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ActualizarInscriptos();
            }
        }

        private void btnCreaAlumno_Click(object sender, EventArgs e)
        {
            this.alumno = (Alumno)this.txtDni.Text;
            if (!lstAlumnosCreados.Items.Contains(this.alumno))
            {
                this.alumno.Nombre = this.txtNombre.Text;
                this.alumno.Apellido = this.txtApellido.Text;
                this.lstAlumnosCreados.Items.Add(alumno);
            }
            else
            {
                MessageBox.Show("El alumno ya existe", "Error al crear", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void View_Load(object sender, EventArgs e)
        {
            this.cmbMaterias.DataSource = Enum.GetValues(typeof(EMateria));
        }

        private void ActualizarInscriptos()
        {
            this.lstAlumnosInscriptosLaboratorio.DataSource = null;
            this.lstAlumnosInscriptosProgramacion.DataSource = null;
            this.lstAlumnosInscriptosLaboratorio.DataSource = this.cursoLaboratorio.Alumnos;
            this.lstAlumnosInscriptosProgramacion.DataSource = this.cursoProgramacion.Alumnos;
        }
    }
}