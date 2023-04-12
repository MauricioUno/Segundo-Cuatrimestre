using System.Text.RegularExpressions;

namespace Entidades
{
    public class Validaciones
    {
        public static int IngresarNumPositivo(string mensaje) 
        {
            int numeroIngresado;
            while (true)
            {
                Console.WriteLine(mensaje);
                int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (numeroIngresado > 1)
                {
                    Console.WriteLine("Valor ingresado!");
                    return numeroIngresado;
                }
                else
                {
                    Console.WriteLine("Error! Valor ingresado no valido!");
                }
            }
        }

        public static bool ValidarRango(int num, int min, int max)
        {
            if (max < min) 
            {
                IntercambiarValores(ref max, ref min);
            }
            return (num >= min && num <= max);
        }

        public static void IntercambiarValores(ref int numUno, ref int numDos) 
        {
            int aux;
            aux = numUno;
            numUno = numDos;
            numDos = aux;
        }

    }


    public class IngresarDatos
    {
        public static int IngresarNum(string mensaje, int min = int.MinValue, int max = int.MaxValue)
        {
            int num;
            bool validacion;

            while (true)
            {
                Console.WriteLine(mensaje);
                validacion = int.TryParse(Console.ReadLine(), out num);
                if (validacion && Validaciones.ValidarRango(num, min, max))
                {
                    Console.WriteLine("Valor ingresado!");
                    return num;
                }
                else
                {
                    Console.WriteLine("Error! Valor ingresado no valido!");
                }
            }
        }

        public static string ProbarRegEx()
        {
            string nombre;
            Match validacion;
            while (true)
            {
                Console.WriteLine("Ingrese el nombre de la mascota: ");
                nombre = Console.ReadLine();
                validacion = Regex.Match(nombre, @"^[a-zA-Z0-9]+$");
                if (validacion != null && validacion.Success)
                {
                    Console.WriteLine("Nombre Ingresado!");
                    return nombre;
                }
                else
                {
                    Console.WriteLine("Error! Ingrese un nombre!");
                }

            }
        }
    }
}
