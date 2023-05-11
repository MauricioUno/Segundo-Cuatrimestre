using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public sealed class Moto : Vehiculo
    {
        #region "Atributos"
        public enum Etipo { Ciclomotor, Scooter, Sport };
        private Etipo tipo;
        private static double valorHora;
        #endregion

        #region "Propiedades"
        /// <summary>
        /// Devuelve la cantidad a cobrar por el estacionamiento de la moto
        /// </summary>
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }

        /// <summary>
        /// Devuelve la constante ETipo correspondiente convertida a string
        /// </summary>
        public override string Descripcion
        {
            get
            {
                return this.tipo.ToString();
            }
        }

        /// <summary>
        /// Cambia el costo por hora del estacionamiento para las motos, siempre y cuando
        /// sea mayor a cero
        /// </summary>
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
                }
            }

        }
        #endregion

        #region "Constructores"
        /// <summary>
        /// Constructor de la clase, establece un valor por defecto al precio por hora 
        /// de estacionamiento
        /// </summary>
        static Moto() 
        {
            Moto.valorHora = 100;
        }

        /// <summary>
        /// Constructor de instancia para la moto
        /// </summary>
        /// <param name="patente">El numero de patente de la moto</param>
        /// <param name="horaIngreso">La hora de ingreso de la moto al estacionamiento</param>
        /// <param name="tipo">El tipo de moto ingresada</param>
        public Moto(string patente, DateTime horaIngreso, Etipo tipo): base(patente, horaIngreso) 
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Sobreescribe al metodo CargoDeEstacionamiento, multiplica las horas que la
        /// moto estuvo estacionada con el precio por hora.
        /// </summary>
        /// <returns> El monto por el estacionamiento de la moto</returns>
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Moto.valorHora;
        }

        /// <summary>
        /// Sobreescribe al metodo MostrarDatos, reune todos los datos
        /// relacionados a la moto
        /// </summary>
        /// <returns>Un string con todos los datos sobre la moto</returns>
        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"****MOTO**** ");
            datos.AppendLine($"Marca: {this.Descripcion} ");

            return datos.ToString();
        }
        
        /// <summary>
        /// Sobreescribe al metodo ToString con MostrarDatos
        /// </summary>
        /// <returns>Un string con todos los datos sobre la moto</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Sobreescritura del metodo equals con la comparacion de patentes
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object? obj)
        {
            if (obj is not null && obj is Vehiculo) 
            {
                return (Vehiculo)obj == this;
            }
            return false;
        }
        #endregion
    }
}
