using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro 
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            Euro.cotzRespectoDolar = 2;
        }

        public Euro(double cantidad) 
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotzRespectoDolar) : this(cantidad) 
        {
            Euro.cotzRespectoDolar = cotzRespectoDolar;
        }

        public static double GetCotizacion() 
        {
            return Euro.cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Euro(double cantidad) 
        {
            return new Euro(cantidad);
        }

        public static explicit operator Dolar(Euro euro) 
        {
            return new Dolar(euro.GetCantidad() / Euro.cotzRespectoDolar);
        }

        public static explicit operator Peso(Euro euro) 
        {
            return (Peso)((Dolar)euro);
        }

    }
}
