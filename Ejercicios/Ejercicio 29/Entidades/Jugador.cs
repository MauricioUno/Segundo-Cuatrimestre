namespace Entidades
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador() 
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre): this() 
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this(dni, nombre) 
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            this.promedioGoles = this.getPromedioGoles();
        }

        public float getPromedioGoles() 
        {
            this.promedioGoles = (float)this.totalGoles / this.partidosJugados;
            return promedioGoles;
        }

        public string MostrarDatos() 
        {
            return $"Nombre: {this.nombre}, " +
                   $"DNI: {this.dni}, " +
                   $"Partidos: {this.partidosJugados}, " +
                   $"Goles: {this.totalGoles}, " +
                   $"Promedio de gol por partido: {this.promedioGoles:0.00}";
        }

        public static bool operator ==(Jugador j1, Jugador j2) 
        {
            return (j1.dni == j2.dni) ;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1== j2);
        }

    }
}