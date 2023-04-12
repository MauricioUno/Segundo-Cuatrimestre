using Entidades;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";
            int anioUno;
            int anioDos;

            anioUno = IngresarDatos.IngresarNum("Ingrese el primer año limite: ", 1);
            anioDos = IngresarDatos.IngresarNum("Ingrese el segundo año limite: ", anioUno);
            Console.ReadKey();

        }
    }
}