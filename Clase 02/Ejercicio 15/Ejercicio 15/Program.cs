using Entidades;

namespace Ejercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";
            char continuar;
            char operacion;
            double primerNumero;
            double segundoNumero;
            double? resultado;
            do
            {
                primerNumero = Validaciones.IngresarNumero("Ingrese el primer número:");
                operacion = Validaciones.IngresarTexto("Ingrese la operacion a realizar (+,-,*,/): ", '+', '-', '*', '/');
                segundoNumero = Validaciones.IngresarNumero("Ingrese el segundo número:");
                resultado = Calculadora.Calcular(primerNumero, segundoNumero, operacion);
                if (resultado != null)
                {
                    Console.WriteLine($"El resultado de {primerNumero} {operacion} {segundoNumero} es: {resultado}");
                }
                else 
                {
                    Console.WriteLine("Error! No se puede dividir por 0");
                }
                Console.WriteLine("Ingrese 'n' para salir, o cualquier tecla para continuar");
                char.TryParse(Console.ReadLine(), out continuar);
                if (continuar == 'n') 
                {
                    break;
                }
                

            } while (true);
            Console.ReadKey();
        }
    }
}