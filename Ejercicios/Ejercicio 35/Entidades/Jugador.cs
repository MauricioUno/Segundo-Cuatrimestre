using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;
namespace Entidades
{
    public class Jugador: Persona
    {
        private int partidosJugados;
        private int totalGoles;

        #region Propiedades
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set 
            {
                if (value >= 0) 
                {
                    this.partidosJugados = value;
                }
            }
        }

        public int GolesAnotados
        {
            get
            {
                return this.totalGoles;
            }
            set 
            {
                if (value >= 0) 
                {
                    this.totalGoles = value;
                }
            }
        }

        public float PromedioGoles
        {
            get
            {
                if (partidosJugados != 0) 
                {
                    return (float)this.totalGoles / this.partidosJugados;
                }
                return 0;
                
            }
        }
        #endregion

        #region Constructores
        public Jugador(int dni, string nombre): base(dni, nombre)
        {

        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this(dni, nombre) 
        {
            this.GolesAnotados = totalGoles;
            this.PartidosJugados = totalPartidos;

        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Jugador j1, Jugador j2) 
        {
            return (j1.Dni == j2.Dni) ;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        #endregion

        #region Metodos
        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Partidos jugados: {this.PartidosJugados}");
            datos.AppendLine($"Goles anotados: {this.GolesAnotados}");

            return datos.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Jugador && (Jugador)obj == this;
        }
        #endregion
    }
}