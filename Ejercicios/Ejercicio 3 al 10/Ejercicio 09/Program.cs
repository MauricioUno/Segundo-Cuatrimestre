using Entidades;
using System.Text;

namespace Ejercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 9";
            int alturaPiramide = Validaciones.IngresarNum("Ingrese la altura de la piramide: ", 1);
            StringBuilder piramide = new StringBuilder();
            string cadena;
            for (int i = 0; i < alturaPiramide; i++) 
            {
                cadena = new string('*', 1 + 2 * i);
                piramide.AppendLine($"{cadena}");
            }
            Console.WriteLine(piramide.ToString());

        }
    }
}