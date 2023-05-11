using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Taxi : Vehiculo
    {
        private int numeroLicencia;
        public Taxi(string matricula, string modelo, double potencia) : base(matricula, modelo, potencia){ }

        public Taxi(string matricula, string modelo, double potencia, int numeroLicencia) : this(matricula, modelo, potencia)
        {
            this.NumeroLicencia = numeroLicencia;
        }

        public int NumeroLicencia { get => numeroLicencia; set => numeroLicencia = value; }

        public override string MostrarDatos() 
        {
            string mensaje = base.MostrarDatos();
            mensaje += $"Numero Licencia: {this.NumeroLicencia}";
            return mensaje;
            
        }
    }
}
