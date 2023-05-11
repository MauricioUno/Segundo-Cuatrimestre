using System.Text.RegularExpressions;
namespace Entidades
{
    public class Jugador
    {
        private static Regex regExNombre;
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;

        static Jugador() 
        {
            Jugador.regExNombre = new Regex("^[0-9A-Za-z ]+$");
        }

   
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }

        public int GolesAnotados
        {
            get
            {
                return this.totalGoles;
            }
        }

        public float PromedioGoles
        {
            get
            {
                return (float)this.totalGoles / this.partidosJugados;
            }
        }

        public string Dni
        {
            get
            {
                return this.dni.ToString();
            }
            set
            {
                int num;
                if (int.TryParse(value, out num) && num > 0)
                {
                    this.dni = num;
                }
                else 
                {
                    this.dni = 0;
                }

            }
        }

        public string Nombre 
        {
            get 
            { 
                return this.nombre;
            }
            set 
            {
                if (Jugador.regExNombre.IsMatch(value))
                {
                    this.nombre = value;
                }
                else 
                {
                    this.nombre = "N/A";
                }
                
            }
        }

        private Jugador()
        {
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.Dni = dni.ToString();
            this.Nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this(dni, nombre) 
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;

        }

        

        public string MostrarDatos() 
        {
            return $"Nombre: {this.Nombre}, " +
                   $"DNI: {this.Dni}, " +
                   $"Partidos: {this.PartidosJugados}, " +
                   $"Goles: {this.GolesAnotados}, " +
                   $"Promedio de gol por partido: {this.PromedioGoles:0.00}";
        }

        public static bool operator ==(Jugador j1, Jugador j2) 
        {
            return (j1.Dni == j2.Dni) ;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1== j2);
        }

    }
}