using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private long dni;
        private string nombre;

        #region Propiedades
        public long Dni 
        {
            get 
            {
                return this.dni;
            }
            set 
            {
                if (value > 0) 
                {
                    this.dni = value;
                }
            }
        }

        public string Nombre 
        {
            get 
            {
                return this.nombre;
            }
            set
            {
                if (value.IsAlphaNumeric())
                {
                    this.nombre = value;
                }
            }
        }
        #endregion

        #region Constructores
        public Persona(string nombre) 
        {
            this.Nombre= nombre;
        }

        public Persona(long dni, string nombre)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }
        #endregion

        #region Metodos
        public virtual string MostrarDatos() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Nombre: {this.Nombre}");
            datos.AppendLine($"DNI: {this.Dni}");

            return datos.ToString();
        }
        #endregion
    }
}
