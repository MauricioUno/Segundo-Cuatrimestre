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

        public static void SetCotizacion(double cotzRespectoDolar)
        {
            Euro.cotzRespectoDolar = cotzRespectoDolar;
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
            return (Dolar)(euro.GetCantidad() / Euro.cotzRespectoDolar);
        }

        public static explicit operator Peso(Euro euro) 
        {
            return (Peso)((Dolar)euro);
        }

        public static bool operator ==(Euro euro, Euro euroDos) 
        {
            return euro.GetCantidad() == euroDos.GetCantidad();
        }

        public static bool operator !=(Euro euro, Euro euroDos)
        {
            return !(euro == euroDos);
        }

        public static bool operator ==(Euro euro, Dolar dolar)
        {
            return euro.GetCantidad() == ((Euro)dolar).GetCantidad();
        }

        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(euro == dolar);
        }

        public static bool operator ==(Euro euro, Peso peso)
        {
            return euro.GetCantidad() == ((Euro)peso).GetCantidad();
        }

        public static bool operator !=(Euro euro, Peso peso)
        {
            return !(euro == peso);
        }

        public static Euro operator +(Euro euro, Dolar dolar) 
        {
            return (Euro)(euro.GetCantidad() + ((Euro)dolar).GetCantidad());
        }

        public static Euro operator -(Euro euro, Dolar dolar) 
        {
            return (Euro)(euro.GetCantidad() - ((Euro)dolar).GetCantidad());
        }

        public static Euro operator +(Euro euro, Peso peso) 
        {
            return euro + (Dolar)peso;
        }

        public static Euro operator -(Euro euro, Peso peso)
        {
            return euro - (Dolar)peso;
        }
    }
}
