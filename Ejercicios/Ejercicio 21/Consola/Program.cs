using Entidades;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit gradoF = 15;
            Celcius gradoC = 35;
            Kelvin gradoK = 20;

            Console.WriteLine(gradoC.GetCantidad());
            Console.WriteLine(gradoF.GetCantidad());
            Console.WriteLine(gradoK.GetCantidad());

            Console.WriteLine(gradoC == gradoF);
            Console.WriteLine(gradoF == gradoK);

            Console.WriteLine((gradoC + gradoK).GetCantidad());
            Console.WriteLine((gradoF - gradoC).GetCantidad());
        }
    }
}