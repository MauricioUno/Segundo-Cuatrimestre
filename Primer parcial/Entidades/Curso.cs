using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Persona> alumnos;
        private EMateria materia;
        private Persona profesor;

        #region "Propiedades"
        public List<Persona> Alumnos
        {
            get
            {
                return this.alumnos;
            }
        }

        public Profesor Profesor
        {
            get
            {              
                return (Profesor)this.profesor;
            }
            set
            {
                this.profesor = value;
            }
        }
        #endregion

        #region "Constructores"
        public Curso(Profesor profe)
        {
            this.profesor= profe;
            this.alumnos = new List<Persona>();
            this.materia = profe.Materia;      
        }
        #endregion

        #region "Sobrecargas"
        public static bool operator ==(Curso curso, Alumno alumno) 
        {
            foreach (Alumno alumn in curso.alumnos) 
            {
                if (alumn == alumno) 
                {
                    return true;
                }
            }
            return false;
            // Forma corta: return curso.alumnos.Contains(alumno); Ya que sobreescribimos el Equals
        }

        public static bool operator !=(Curso curso, Alumno alumno)
        {
            return !(curso == alumno);
        }
        #endregion

        #region "Metodos"
        public string InscribirAlumno(Alumno alumno) 
        {
            if (this != alumno && alumno + this.materia) 
            {
                
                this.alumnos.Add(alumno);
                return $"Se incribio al alumno a la materia\n{alumno.Informacion}";
            }
            return $"Ya inscripto o no se pudo inscribir al alumno a la materia";
        }

        public static void EvaluarAlumnos(Curso curso) 
        {
            foreach (Alumno alumno in curso.Alumnos) 
            {
                alumno.RendirExamen(curso.materia);
            }
        }

        public static string MostrarInformacionCurso(Curso curso)
        {
            StringBuilder informacion = new StringBuilder();
            informacion.AppendLine($"Materia: {curso.materia}");
            informacion.AppendLine($"{curso.profesor.Informacion}");
            foreach (Alumno alumno in curso.alumnos) 
            {
                informacion.AppendLine($"{alumno.Informacion}");
            }
            return informacion.ToString();
        }

        public override string ToString()
        {
            return $"Curso de {this.materia}";
        }
        #endregion
    }
}
