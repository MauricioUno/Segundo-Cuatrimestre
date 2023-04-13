using Billetes;

namespace Cotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Peso monedaArgentina = 400;
            Console.WriteLine(((Euro)(Dolar)monedaArgentina).GetCantidad());
        }
    }
}