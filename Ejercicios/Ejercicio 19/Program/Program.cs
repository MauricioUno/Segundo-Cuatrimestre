using Entidades;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Console.WriteLine(sumador.Sumar("Hola", "|Adios"));
            Console.WriteLine(sumador.Sumar(13,200));

            Sumador sumadorDos = new Sumador(2);
            Console.WriteLine(sumadorDos.Sumar("No saludo", " KKK"));
            Console.WriteLine(sumadorDos.Sumar(20, 500));

            Console.WriteLine((int)sumador);
            Console.WriteLine((int)sumadorDos);
            Console.WriteLine(sumador + sumadorDos);
            Console.WriteLine(sumador|sumadorDos);

        }
    }
}