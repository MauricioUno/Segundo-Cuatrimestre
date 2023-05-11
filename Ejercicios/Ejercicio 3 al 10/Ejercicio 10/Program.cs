using Entidades;
using System.Text;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            int alturaPiramide = Validaciones.IngresarNum("Ingrese la altura de la piramide: ", 1);
            StringBuilder piramide = new StringBuilder();
            string cadena;
            string espacio;
            for (int i = 0; i < alturaPiramide; i++)
            {
                espacio = new string(' ', (alturaPiramide - i));
                cadena = new string('*', 1 + 2 * i);
                piramide.AppendLine($"{espacio}{cadena}");
            }
            Console.WriteLine(piramide.ToString());

        }
    }
}