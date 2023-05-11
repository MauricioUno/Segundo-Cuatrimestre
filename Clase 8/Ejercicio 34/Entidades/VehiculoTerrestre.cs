using System.Text;

namespace Entidades
{
    public enum EColores {Rojo, Blanco, Azul, Gris, Negro }
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private EColores color;


        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public virtual string MostrarDatos() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Ruedas: {this.cantidadRuedas}");
            datos.AppendLine($"Puertas: {this.cantidadPuertas}");
            datos.AppendLine($"Color: {this.color}");

            return datos.ToString();
        }
    }

    public class Automovil: VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short ruedas, short puertas, EColores color, short marchas, int pasajeros): base(ruedas, puertas, color) 
        {
            this.cantidadMarchas = marchas;
            this.cantidadPasajeros = pasajeros;
        }

        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Datos Automovil:");
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Marchas: {this.cantidadMarchas}");
            datos.AppendLine($"Pasajeros: {this.cantidadPasajeros}");

            return datos.ToString();
        }
    }

    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion(short ruedas, short puertas, EColores color, short marchas, int pesoCarga) : base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.pesoCarga = pesoCarga;
        }

        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Datos Camion:");
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Marchas: {this.cantidadMarchas}");
            datos.AppendLine($"Peso de carga: {this.pesoCarga}");

            return datos.ToString();
        }
    }

    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short ruedas, short puertas, EColores color, short cilindrada) : base(ruedas, puertas, color)
        {
            this.cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Datos Moto:");
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Cilindrada: {this.cilindrada}");

            return datos.ToString();
        }
    }
}