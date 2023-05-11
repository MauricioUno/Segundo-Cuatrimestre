using Entidades;
namespace Ejercicio_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Libro icathia = new Libro();

            // Prueba agregando una pagina que antes no existia
            Console.WriteLine(icathia[0]);
            icathia[0] = "Muchas civilizaciones han existido a lo largo de la historia de la humanidad, a dia de hoy se siguen descubriendo";
            Console.WriteLine(icathia[0]);

            //Si no existe, se guarda en la siguiente pagina
            Console.WriteLine(icathia[12]);
            icathia[12] = "ruinas que permiten entender mas a las sociedades del pasado o incluso hacen que se cuestione lo que se tiene";
            Console.WriteLine(icathia[12]);

            Console.WriteLine(icathia[1]);
        }
    }
}