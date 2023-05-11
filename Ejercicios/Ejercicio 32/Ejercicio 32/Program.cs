using Entidades;

namespace Ejercicio_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipo doubleIuEl = new Equipo(5, "GC");
            Jugador p1 = new Jugador(2012, "S", 4, 2);
            Jugador p2 = new Jugador(2018, "M", 1, 6);
            Jugador p3 = new Jugador(2018, "K", 7, 3);

            Console.WriteLine(p3.MostrarDatos()); // Datos

            Console.WriteLine(doubleIuEl + p1); // True
            Console.WriteLine(doubleIuEl + p2); // True
            Console.WriteLine(doubleIuEl + p3); // False

            Console.WriteLine(p1 == p2); // False
            Console.WriteLine(p2 == p3); // True

            Console.WriteLine(doubleIuEl.MostrarDatos()); // Muestra datos 2 jugadores
        }
    }
}