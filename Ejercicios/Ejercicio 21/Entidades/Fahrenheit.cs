using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fahrenheit
    {
        private double cantidad;

        public Fahrenheit(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static implicit operator Fahrenheit(double cantidad)
        {
            return new Fahrenheit(cantidad);
        }

        public static explicit operator Kelvin(Fahrenheit grados)
        {
            return new Kelvin((grados.cantidad + 459.67) * 5 / 9);
        }

        public static explicit operator Celcius(Fahrenheit grados)
        {
            return new Celcius((grados.cantidad - 32) * 5 / 9);
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static bool operator ==(Fahrenheit gradoA, Fahrenheit gradoB)
        {
            return gradoA.cantidad == gradoB.cantidad;
        }

        public static bool operator !=(Fahrenheit gradoA, Fahrenheit gradoB)
        {
            return !(gradoA == gradoB);
        }

        public static bool operator ==(Fahrenheit gradoA, Celcius gradoB)
        {
            return gradoA == (Fahrenheit)gradoB;
        }

        public static bool operator !=(Fahrenheit gradoA, Celcius gradoB)
        {
            return !(gradoA == (Fahrenheit)gradoB);
        }

        public static bool operator ==(Fahrenheit gradoA, Kelvin gradoB)
        {
            return gradoA == (Fahrenheit)gradoB;
        }

        public static bool operator !=(Fahrenheit gradoA, Kelvin gradoB)
        {
            return !(gradoA == (Fahrenheit)gradoB);
        }

        public static Fahrenheit operator +(Fahrenheit gradoA, Fahrenheit gradoB)
        {
            return new Fahrenheit(gradoA.cantidad + gradoB.cantidad);
        }

        public static Fahrenheit operator -(Fahrenheit gradoA, Fahrenheit gradoB)
        {
            return new Fahrenheit(gradoA.cantidad - gradoB.cantidad);
        }

        public static Fahrenheit operator +(Fahrenheit gradoA, Kelvin gradoB)
        {
            return gradoA + (Fahrenheit)gradoB;
        }

        public static Fahrenheit operator -(Fahrenheit gradoA, Kelvin gradoB)
        {
            return gradoA - (Fahrenheit)gradoB;
        }

        public static Fahrenheit operator +(Fahrenheit gradoA, Celcius gradoB)
        {
            return gradoA + (Fahrenheit)gradoB;
        }

        public static Fahrenheit operator -(Fahrenheit gradoA, Celcius gradoB)
        {
            return gradoA - (Fahrenheit)gradoB;
        }
    }
}
