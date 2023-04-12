using Entidades;
namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";
            int numero;
            int i;
            int anteriores;
            int sumaAnteriores;
            int siguientes;
            int sumaSiguientes;

            numero = Validaciones.IngresarNumPositivo("Ingrese el numero limite para buscar centros numericos: ");
            for (i = 2; i < numero + 1; i++) 
            {
                sumaAnteriores = 0;
                for (anteriores = 1; anteriores < i; anteriores++)
                {
                    sumaAnteriores += anteriores;
                }

                sumaSiguientes = 0;
                for (siguientes = i + 1; sumaSiguientes < sumaAnteriores; siguientes++) 
                {
                    sumaSiguientes += siguientes;
                }

                if (sumaAnteriores == sumaSiguientes)
                {
                    Console.WriteLine($"{sumaAnteriores},{sumaSiguientes}");
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
            
        }
    }
}