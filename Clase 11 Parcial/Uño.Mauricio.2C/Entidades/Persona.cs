using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        protected int dni;
        private string nombre;

        #region "Propiedades"
        public string Apellido 
        {
            get 
            {
                return this.apellido;
            }
            set 
            {
                this.apellido = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public abstract string Informacion 
        {
            get;
        }
        #endregion

        #region "Constructores"
        protected Persona(int dni) 
        {
            this.dni = dni;
        }
        #endregion

        #region "Sobrecargas"
        public static bool operator ==(Persona personaA, Persona personaB) 
        {
            return personaA.dni == personaB.dni;
        }

        public static bool operator !=(Persona personaA, Persona personaB)
        {
            return !(personaA == personaB);
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Metodo virtual, arma un mensaje con todos los datos de la persona
        /// </summary>
        /// <returns> Un string con los datos </returns>
        protected virtual string MostrarDatos() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Nombre: {this.Nombre}");
            datos.AppendLine($"Apellido: {this.Apellido}");
            datos.AppendLine($"DNI: {this.dni}");

            return datos.ToString();
        }
        
        /// <summary>
        /// Sobreescritura del metodo Equals, ahora se utilizara la sobrecarga de Persona
        /// que determina la igualdad mediante el DNI
        /// </summary>
        /// <param name="obj"> El objeto con el que se compara</param>
        /// <returns>True si tienen el mismo DNI, False si tienen distinto DNI o no es una Persona</returns>
        public override bool Equals(object? obj)
        {
            if (obj is not null && obj is Persona) 
            {
                return (Persona)obj == this;
            }
            return false;
        }

        /// <summary>
        /// Sobreescritura del metodo GetHashCode, devuelve el HashCode del DNI de la persona
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.dni.GetHashCode();
        }
        #endregion
    }

}