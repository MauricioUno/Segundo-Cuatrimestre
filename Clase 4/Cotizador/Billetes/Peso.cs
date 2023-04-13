using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Peso()
        {
            Peso.cotzRespectoDolar = 400;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotzRespectoDolar) : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotzRespectoDolar;
        }

        public static double GetCotizacion()
        {
            return Peso.cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        public static explicit operator Dolar(Peso peso) 
        {
            return new Dolar(peso.cantidad / Peso.cotzRespectoDolar);
        }

        public static explicit operator Euro(Peso peso) 
        {
            return (Euro)((Dolar)peso);
        }
    }
}
