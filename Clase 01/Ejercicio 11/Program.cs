using Entidades;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";

            int numero;
            int numeroMayor = int.MaxValue;
            int numeroMenor = int.MinValue;

            int i = 0;
            bool validacion;
            int rangoMaximo = 100;
            int rangoMinimo = -100;

            int acumulador = 0;
            float promedio;
            int cant = 10;

            do
            {
                Console.WriteLine($"Ingrese un numero entero dentro del rango ({rangoMinimo},{rangoMaximo}): ");
                validacion = int.TryParse(Console.ReadLine(), out numero);
                if (validacion && Validacion.ValidarRango(numero, rangoMinimo, rangoMaximo))
                {
                    if (numeroMayor < numero || i == 0)
                    {
                        numeroMayor = numero;
                    }

                    if (numeroMenor > numero || i == 0)
                    {
                        numeroMenor = numero;
                    }

                    acumulador += numero;
                    i += 1;
                }
                else 
                {
                    Console.WriteLine("Error! Valor ingresado no valido!");
                }
                
            } while (i < cant);
            promedio = (float)acumulador / (float)cant;
            Console.WriteLine(acumulador);
            Console.WriteLine($"El numero ingresado de mayor valor es: {numeroMayor}");
            Console.WriteLine($"El numero ingresado de menor valor es: {numeroMenor}");
            Console.WriteLine($"El promedio de los numeros ingresados es de {promedio.ToString("0.00")}");
            Console.ReadKey();
        }
    }
}