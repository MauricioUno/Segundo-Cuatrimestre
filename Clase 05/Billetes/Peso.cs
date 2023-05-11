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
        public static void SetCotizacion(double cotzRespectoDolar)
        {
            Peso.cotzRespectoDolar = cotzRespectoDolar;
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
            return (Dolar)(peso.cantidad / Peso.cotzRespectoDolar);
        }

        public static explicit operator Euro(Peso peso) 
        {
            return (Euro)((Dolar)peso);
        }

        public static bool operator ==(Peso peso, Peso pesoDos)
        {
            return peso.GetCantidad() == pesoDos.GetCantidad();
        }

        public static bool operator !=(Peso peso, Peso pesoDos)
        {
            return !(peso == pesoDos);
        }

        public static bool operator ==(Peso peso, Euro euro)
        {
            return euro == peso;
        }

        public static bool operator !=(Peso peso, Euro euro)
        {
            return !(euro == peso);
        }

        public static bool operator ==(Peso peso, Dolar dolar)
        {
            return dolar == peso;
        }

        public static bool operator !=(Peso peso, Dolar dolar)
        {
            return !(dolar == peso);
        }

        public static Peso operator +(Peso peso, Dolar dolar) 
        {
            return (Peso)(dolar + peso);
        }

        public static Peso operator -(Peso peso, Dolar dolar) 
        {
            return (Peso)(peso.GetCantidad() - ((Peso)dolar).GetCantidad());
        }

        public static Peso operator +(Peso peso, Euro euro) 
        {
            return (peso + (Dolar)euro);
        }

        public static Peso operator -(Peso peso, Euro euro)
        {
            return (peso - (Dolar)euro);
        }
    }
}
