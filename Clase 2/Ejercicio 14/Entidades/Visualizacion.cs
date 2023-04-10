using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Visualizacion
    {
        public static string IngresarTexto(string mensaje, params string[] opciones)
        {
            string texto;
            bool validacion;

            Console.WriteLine(mensaje);
            texto = Console.ReadLine();
            validacion = Validaciones.ValidarTexto(texto, opciones);
            while (!validacion)
            {
                Console.WriteLine("Error! Ingrese una opcion valida!");
                Console.WriteLine(mensaje);
                texto = Console.ReadLine();
                validacion = Validaciones.ValidarTexto(texto, opciones);
            }

            return texto;
        }

        public static double IngresarMedida(string mensaje) 
        {
            double medida;
            bool validacion;
            Console.WriteLine(mensaje);
            double.TryParse(Console.ReadLine(), out medida);
            //Console.WriteLine(medida);
            validacion = Validaciones.ValidarNumPositivo(medida);
            while (!validacion)
            {
                Console.WriteLine("Error! La medida debe ser mayor a cero!");
                Console.WriteLine(mensaje);
                double.TryParse(Console.ReadLine(), out medida);
                validacion = Validaciones.ValidarNumPositivo(medida);
            }
            return medida;
        }
    }
}