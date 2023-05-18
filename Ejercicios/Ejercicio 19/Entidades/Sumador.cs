using System.Runtime.CompilerServices;

namespace Entidades
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas += 1;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas += 1;
            return $"{a}{b}";
        }

        public static explicit operator int(Sumador sumador)
        {
            return sumador.cantidadSumas;
        }

        public static long operator +(Sumador sumadorA, Sumador sumadorB)
        {
            return sumadorA.cantidadSumas + sumadorB.cantidadSumas;
        }

        public static bool operator |(Sumador sumadorA, Sumador sumadorB) 
        {
            return sumadorA.cantidadSumas == sumadorB.cantidadSumas;
        }
    }
}