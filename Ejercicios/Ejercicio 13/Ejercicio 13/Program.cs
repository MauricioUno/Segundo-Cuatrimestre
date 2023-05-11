using Entidades;
namespace Ejercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Conversor.DecimalABinario(14));
            Console.WriteLine(Conversor.BinarioADecimal("111000001111"));
        }
    }
}