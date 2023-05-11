using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autobus: Vehiculo
    {
        private int numeroPlazas;
        public Autobus(string matricula, string modelo, double potencia, int numeroLicencia) : base(matricula, modelo, potencia)
        {
            this.NumeroPlazas = numeroLicencia;
        }

        public int NumeroPlazas { get => numeroPlazas; set => numeroPlazas = value; }
    }
}
