using System.Reflection.Emit;

namespace Entidades
{
    public class Validaciones
    {
        public static double IngresarNumero(string mensaje)
        {
            double numero;
            bool validacion;
            Console.WriteLine(mensaje);
            validacion = double.TryParse(Console.ReadLine(), out numero);
            while (!validacion)
            {
                Console.WriteLine("Error! Valor ingresado no valido!");
                Console.WriteLine(mensaje);
                validacion = double.TryParse(Console.ReadLine(), out numero);
            }
            return numero;
        }

        public static char IngresarTexto(string mensaje, params char[] opciones) 
        {
            char operacion;
            bool validacion = false;

            Console.WriteLine(mensaje);
            char.TryParse(Console.ReadLine(), out operacion);
            if (opciones.Contains(operacion))
            {
                validacion = true;
            }
            while (!validacion)
            {
                Console.WriteLine("Error! Ingrese una opcion valida!");
                Console.WriteLine(mensaje);
                char.TryParse(Console.ReadLine(), out operacion);
                if (opciones.Contains(operacion))
                {
                    validacion = true;
                }
            }

            return operacion;
        }

    }
}