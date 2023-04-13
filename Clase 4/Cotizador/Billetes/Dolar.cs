namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotzRespectoDolar) : this(cantidad)
        {
            Dolar.cotzRespectoDolar = cotzRespectoDolar;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static explicit operator Peso(Dolar dolar) 
        {
            return new Peso(dolar.GetCantidad() * Peso.GetCotizacion());
        }

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.GetCantidad() * Euro.GetCotizacion());
        }
    }
}