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
            return (Peso)(dolar.GetCantidad() * Peso.GetCotizacion());
        }

        public static explicit operator Euro(Dolar dolar)
        {
            return (Euro)(dolar.GetCantidad() * Euro.GetCotizacion());
        }

        public static bool operator ==(Dolar dolar, Dolar dolarDos)
        {
            return dolar.GetCantidad() == dolarDos.GetCantidad();
        }

        public static bool operator !=(Dolar dolar, Dolar dolarDos)
        {
            return !(dolar == dolarDos);
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            return euro == dolar;
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(euro == dolar);
        }

        public static bool operator ==(Dolar dolar, Peso peso)
        {
            return (Euro)peso == dolar;
        }

        public static bool operator !=(Dolar dolar, Peso peso)
        {
            return !(dolar == peso);
        }

        public static Dolar operator +(Dolar dolar, Euro euro) 
        {
            return (Dolar)(euro + dolar);
        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            return (Dolar)(dolar.GetCantidad() - ((Dolar)euro).GetCantidad());
        }

        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            return (dolar + (Euro)peso);
        }

        public static Dolar operator -(Dolar dolar, Peso peso)
        {
            return (dolar - (Euro)peso);
        }


    }
}