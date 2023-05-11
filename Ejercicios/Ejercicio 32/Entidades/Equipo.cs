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
            bool result = false;
            if (equipo.jugadores.Count < equipo.cantidadJugadores) 
            {
                foreach (Jugador player in equipo.jugadores) 
                {
                    if (player == jugador) 
                    {
                        return result;
                    }
                }
                equipo.jugadores.Add(jugador);
                result = true;
            }
            return result;
        }

        public string MostrarDatos() 
        {
            string datosEquipo = "";
            foreach(Jugador jugador in this.jugadores) 
            {
                datosEquipo += $"{jugador.MostrarDatos()}\n";
            }
            return datosEquipo;
        }
    }
}
