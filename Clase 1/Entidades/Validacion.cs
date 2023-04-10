using System.Text.RegularExpressions;

namespace Entidades
{
    public class Validacion
    {
        public static bool ValidarRango(int num, int min, int max)
        {
            return (num >= min && num <= max);
        }

        public static bool ValidarOpcionesTexto(string textoIngresado, params string[] valores)
        {
            return valores.Contains(textoIngresado);
        }

    }

    public class IngresarDatos 
    {
        public static int IngresarNum(int min, int max, string mensaje) 
        {
            int num;
            bool validacion;

            while (true)
            {
                Console.WriteLine(mensaje);
                validacion = int.TryParse(Console.ReadLine(), out num);
                if (validacion && Validacion.ValidarRango(num, min, max))
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

        public static string IngresarTexto(string mensaje, params string[] opciones)
        {
            string texto;
            while (true)
            {
                Console.WriteLine(mensaje);
                texto = Console.ReadLine();
                if (Validacion.ValidarOpcionesTexto(texto, opciones))
                {
                    Console.WriteLine("Opcion ingresada!");
                    return texto;
                }
                else 
                {
                    Console.WriteLine("Error! Ingrese una opcion valida!");
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