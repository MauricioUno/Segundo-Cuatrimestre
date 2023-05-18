using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno: Persona
    {
        private string legajo;
        private Dictionary<EMateria, List<int>> materiasAsignadas;

        #region "Propiedades"
        public override string Informacion
        {
            get 
            {
                StringBuilder datosAlumno = new StringBuilder();
                datosAlumno.AppendLine("Datos Alumno:");
                datosAlumno.AppendLine(this.MostrarDatos());
                return datosAlumno.ToString();
            }
        }

        public List<int> this[EMateria materia] 
        {
            get 
            {
                if (this == materia) 
                {
                    return this.materiasAsignadas[materia];
                }
                return null;
            }
        }
        #endregion

        #region "Constructores"
        private Alumno(int dni): base(dni)
        {
            materiasAsignadas = new Dictionary<EMateria, List<int>>();
        }

        public Alumno(int dni, string legajo): this(dni) 
        {
            this.legajo = legajo;
        }
        #endregion

        #region "Sobrecargas"
        public static bool operator ==(Alumno alumno, EMateria materia) 
        {
            foreach (KeyValuePair<EMateria, List<int>> materia2 in alumno.materiasAsignadas) 
            {
                if (materia2.Key == materia) 
                {
                    return true;
                }
            }
            return false;
            // Metodo mas corto: return alumno.materiasAsignadas.ContainsKey(materia);
        }

        public static bool operator !=(Alumno alumno, EMateria materia)
        {
            return !(alumno == materia);
        }

        public static bool operator +(Alumno alumno, EMateria materia) 
        {
            if (!(alumno == materia)) 
            {
                alumno.materiasAsignadas.Add(materia, new List<int>());
                return true;
            }
            return false;
        }

        public static implicit operator Alumno(string dni) 
        {
            int dniEntero;
            int.TryParse(dni, out dniEntero);
            Alumno alumno = new Alumno(dniEntero);
            alumno.legajo = $"L-{alumno.GetHashCode()}";
            return alumno;
           
        }
        #endregion

        #region "Metodos"
        public bool RendirExamen(EMateria materia) 
        {
            if (this == materia) 
            {
                Random nota = new Random();
                this[materia].Add(nota.Next(1, 10));
                return true;
            }
            return false;
        }

        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Nro Legajo: {this.legajo}");
            datos.AppendLine($"Materias: {string.Join("|",this.materiasAsignadas.Keys)}");

            return datos.ToString();
        }

        public override string ToString() 
        {
            return $"{this.Nombre} {this.Apellido} - {this.legajo}";
        }
        #endregion


    }
}
