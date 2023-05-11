using System.Text;
using System.Text.RegularExpressions;
namespace Clases
{
    public abstract class Vehiculo
    {
        public enum EVehiculos { Automovil, Moto };
        private DateTime horaIngreso;
        private DateTime horaEgreso;
        private string patente;

        public abstract double CostoEstadia
        {
            get;
        }

        public abstract string Descripcion
        {
            get;
        }

        public DateTime HoraIngreso
        {
            get
            {
                return this.horaIngreso;
            }          
        }
        public DateTime HoraEgreso 
        { 
            get 
            { 
                return this.horaEgreso;
            }
            set
            {
                if (value > this.horaIngreso) 
                {
                    this.horaEgreso = value;
                }
                
            }
        }
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (this.ValidarPatente(value)) 
                {
                    this.patente = value;
                }
                
            }
        }

        public Vehiculo(string patente, DateTime horaIngreso) 
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }

        private bool ValidarPatente(string patente) 
        {
            Regex regExPatente = new Regex("^[A-Za-z0-9]{6,7}$");
            return regExPatente.IsMatch(patente);
        }

        protected virtual double CargoDeEstacionamiento() 
        {
            return (this.horaEgreso - this.horaIngreso).TotalHours;
        }

        protected virtual string MostrarDatos() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Patente: {this.Patente} ");
            datos.AppendLine($"Hora de ingreso: {this.horaIngreso} ");

            return datos.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2) 
        {
            return v1.Patente == v2.Patente;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }

}