using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor: Persona
    {
        private string email;
        private EMateria materiaAsignada;

        #region "Propiedades"
        public override string Informacion
        {
            get
            {
                StringBuilder datosProfesor = new StringBuilder();
                datosProfesor.AppendLine("Datos Profesor:");
                datosProfesor.AppendLine(this.MostrarDatos());
                return datosProfesor.ToString();
            }
        }

        public EMateria Materia
        {
            get 
            {
                return this.materiaAsignada;
            }
            set 
            {
                this.materiaAsignada = value;
            }
        }
        #endregion

        #region "Constructores"
        public Profesor(int dni): base(dni)
        {

        }

        public Profesor(int dni, string email) : this(dni) 
        {
            this.email = email;
        }

        public Profesor(int dni, string email, EMateria materiaAsignada) : this(dni, email) 
        {
            this.Materia = materiaAsignada;
        }
        #endregion

        #region "Metodos"
        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.MostrarDatos());
            datos.AppendLine($"Email: {this.email}");
            datos.AppendLine($"Materia Asignada: {this.Materia}");

            return datos.ToString();
        }

        public override string ToString()
        {
            return $"Profesor - {this.Materia}";
        }

        public bool Evaluar(Alumno alumno) 
        {
            return alumno.RendirExamen(this.Materia);
        }
        #endregion
    }
}
