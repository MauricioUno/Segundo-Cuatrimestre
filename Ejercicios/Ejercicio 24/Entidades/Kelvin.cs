using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Kelvin
    {
        private double cantidad;

        public Kelvin(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static implicit operator Kelvin(double cantidad)
        {
            return new Kelvin(cantidad);
        }

        public static explicit operator Fahrenheit(Kelvin grados)
        {
            return new Fahrenheit((grados.cantidad*9/5) - 459.67);
        }

        public static explicit operator Celcius(Kelvin grados)
        {
            return (Celcius)(Fahrenheit)grados;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static bool operator ==(Kelvin gradoA, Kelvin gradoB)
        {
            return gradoA.cantidad == gradoB.cantidad;
        }

        public static bool operator !=(Kelvin gradoA, Kelvin gradoB)
        {
            return !(gradoA == gradoB);
        }

        public static bool operator ==(Kelvin gradoA, Celcius gradoB)
        {
            return gradoA == (Kelvin)gradoB;
        }

        public static bool operator !=(Kelvin gradoA, Celcius gradoB)
        {
            return !(gradoA == (Kelvin)gradoB);
        }

        public static bool operator ==(Kelvin gradoA, Fahrenheit gradoB)
        {
            return gradoA == (Kelvin)gradoB;
        }

        public static bool operator !=(Kelvin gradoA, Fahrenheit gradoB)
        {
            return !(gradoA == (Kelvin)gradoB);
        }

        public static Kelvin operator +(Kelvin gradoA, Kelvin gradoB)
        {
            return new Kelvin(gradoA.cantidad + gradoB.cantidad);
        }

        public static Kelvin operator -(Kelvin gradoA, Kelvin gradoB)
        {
            return new Kelvin(gradoA.cantidad - gradoB.cantidad);
        }

        public static Kelvin operator +(Kelvin gradoA, Fahrenheit gradoB)
        {
            return gradoA + (Kelvin)gradoB;
        }

        public static Kelvin operator -(Kelvin gradoA, Fahrenheit gradoB)
        {
            return gradoA - (Kelvin)gradoB;
        }

        public static Kelvin operator +(Kelvin gradoA, Celcius gradoB)
        {
            return gradoA + (Kelvin)gradoB;
        }

        public static Kelvin operator -(Kelvin gradoA, Celcius gradoB)
        {
            return gradoA - (Kelvin)gradoB;
        }
    }
}
