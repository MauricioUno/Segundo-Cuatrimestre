using Entidades;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2002, 11, 8);
            Equipo dinamita = new Equipo(5, "GC");
            DirectorTecnico dt1 = new DirectorTecnico("Pescado", fecha);
            DirectorTecnico dt2 = new DirectorTecnico("Javier", fecha);
            Jugador p1 = new Jugador(2012, "S", 4, 2);
            Jugador p2 = new Jugador(2018, "M", 1, 6);
            Jugador p3 = new Jugador(2018, "K", 7, 3);

            Console.WriteLine(dinamita + p2); // True
            Console.WriteLine(dinamita + p3); // False
            Console.WriteLine($"{dinamita + p1}\n"); // True

            Console.WriteLine(p1 == p2); // False
            Console.WriteLine(p2 == p3); // True
            Console.WriteLine($"{dt1 == dt2}\n"); // True

            Console.WriteLine(dinamita.MostrarDatos()); // Muestra datos 2 jugadores
        }
    }
}