namespace Entidades
{
    public class Celcius
    {
        private double cantidad;

        public Celcius(double cantidad) 
        {
            this.cantidad = cantidad;
        }

        public static implicit operator Celcius(double cantidad) 
        {
            return new Celcius(cantidad);
        }

        public static explicit operator Fahrenheit(Celcius grados) 
        {
            return new Fahrenheit(grados.cantidad * (9 / 5) + 32);
        }

        public static explicit operator Kelvin(Celcius grados)
        {
            return (Kelvin)(Fahrenheit)grados;
        }

        public double GetCantidad() 
        {
            return this.cantidad;
        }

        public static bool operator ==(Celcius gradoA, Celcius gradoB) 
        {
            return gradoA.cantidad == gradoB.cantidad;
        }

        public static bool operator !=(Celcius gradoA, Celcius gradoB)
        {
            return !(gradoA == gradoB);
        }

        public static bool operator ==(Celcius gradoA, Kelvin gradoB)
        {
            return gradoA == (Celcius)gradoB;
        }

        public static bool operator !=(Celcius gradoA, Kelvin gradoB)
        {
            return !(gradoA == (Celcius)gradoB);
        }

        public static bool operator ==(Celcius gradoA, Fahrenheit gradoB)
        {
            return gradoA == (Celcius)gradoB;
        }

        public static bool operator !=(Celcius gradoA, Fahrenheit gradoB)
        {
            return !(gradoA == (Celcius)gradoB);
        }

        public static Celcius operator +(Celcius gradoA, Celcius gradoB) 
        {
            return new Celcius(gradoA.cantidad + gradoB.cantidad);
        }

        public static Celcius operator -(Celcius gradoA, Celcius gradoB)
        {
            return new Celcius(gradoA.cantidad - gradoB.cantidad);
        }

        public static Celcius operator +(Celcius gradoA, Fahrenheit gradoB)
        {
            return gradoA + (Celcius)gradoB;
        }

        public static Celcius operator -(Celcius gradoA, Fahrenheit gradoB)
        {
            return gradoA - (Celcius)gradoB;
        }

        public static Celcius operator +(Celcius gradoA, Kelvin gradoB)
        {
            return gradoA + (Celcius)gradoB;
        }

        public static Celcius operator -(Celcius gradoA, Kelvin gradoB)
        {
            return gradoA - (Celcius)gradoB;
        }

    }
}