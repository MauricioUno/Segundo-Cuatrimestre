using Billetes;

namespace Cotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Peso monedaArgentina = 1000; // 2.5 dolares
            Euro monedaE = 6; // 3 dolares
            Dolar monedaG = 10;

            Dolar prueba = monedaG - monedaArgentina;
            Euro prueba2 = monedaE - monedaG;
            Peso prueba3 = monedaArgentina - monedaE;
            Console.WriteLine((prueba3).GetCantidad());
            Console.WriteLine((monedaArgentina - monedaG).GetCantidad());
            Console.WriteLine((prueba).GetCantidad());
            Console.WriteLine((prueba2).GetCantidad());
            //Console.WriteLine(monedaE == monedaG);
            //Console.WriteLine(monedaG == monedaE);
            //Console.WriteLine(monedaG == monedaArgentina);
            //Console.WriteLine(monedaArgentina == monedaG);
            //Console.WriteLine(monedaE == monedaArgentina);
            //Console.WriteLine(monedaArgentina == monedaE);
        }
    }
}