using Entidades;
namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int numeroIngresado;
            bool primo;
            int numero;
            int divisor;
            List<int> listaPrimos = new List<int>();

            numeroIngresado = Validaciones.IngresarNumPositivo("Ingrese el numero limite para buscar numeros primos: ");

            for (numero = 2; numero < numeroIngresado + 1; numero++)
            {
                primo = true;
                for (divisor = 2; divisor <= numero / 2; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    listaPrimos.Add(numero);
                }
            }

            Console.WriteLine($"Lista de numero primos: {String.Join(",", listaPrimos)}");
        }
    }
}