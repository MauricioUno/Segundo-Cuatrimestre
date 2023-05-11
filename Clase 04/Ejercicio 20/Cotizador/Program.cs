using Billetes;

namespace Cotizador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cotizador";
            // 400 pesos = 1 dolar
            // 2 euros = 1 dolar
            Peso pesito = 1500;
            Euro euro = 6; 
            Dolar dolar = 3;

            Console.WriteLine(pesito != dolar);
            Console.WriteLine(pesito == dolar);
           
            Console.WriteLine(dolar != pesito);
            Console.WriteLine(dolar == pesito);

            Console.WriteLine(euro != dolar);
            Console.WriteLine(euro == dolar);

            Console.WriteLine(euro != pesito);
            Console.WriteLine(euro == pesito);   

            Console.WriteLine(((Dolar)pesito).GetCantidad());
            Console.WriteLine(((Euro)dolar).GetCantidad());
        }
    }
}