using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private short cantidadJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo() 
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre): this()
        {
            this.cantidadJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo equipo, Jugador jugador) 
        {
            if (equipo.jugadores.Count < equipo.cantidadJugadores && !equipo.jugadores.Contains(jugador))
            {
                equipo.jugadores.Add(jugador);
                return true;
            }
            return false;
        }

        public string MostrarDatos() 
        {
            StringBuilder datosEquipo = new StringBuilder();
            datosEquipo.AppendLine($"Nombre Equipo: {this.nombre}");
            datosEquipo.AppendLine($"---Jugadores---\n");
            foreach(Jugador jugador in this.jugadores) 
            {
                datosEquipo.AppendLine($"{jugador.MostrarDatos()}");
            }
            return datosEquipo.ToString();
        }
    }
}
