using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico: Persona
    {
        private DateTime fechaNacimiento;

        #region Propiedades
        public DateTime FechaNacimiento 
        {
            get 
            {
                return this.fechaNacimiento;
            }
            set 
            {
                if (value.Year <= 2023) 
                {
                    this.fechaNacimiento = value;
                }
                
            } 
        }
        #endregion

        #region Constructores
        private DirectorTecnico(string nombre): base(nombre) 
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento): this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(DirectorTecnico dtRiver, DirectorTecnico dtBoca) 
        {
            return dtRiver.fechaNacimiento == dtBoca.fechaNacimiento;
        }

        public static bool operator !=(DirectorTecnico dtRiver, DirectorTecnico dtBoca)
        {
            return !(dtRiver == dtBoca);
        }
        #endregion

        #region Metodos
        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.Append($"Fecha de nacimiento: {this.FechaNacimiento}");

            return datos.ToString();
        }
        #endregion
    }
}
