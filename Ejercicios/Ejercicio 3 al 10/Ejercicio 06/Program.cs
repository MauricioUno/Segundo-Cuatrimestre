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

            anioUno = Validaciones.IngresarNum("Ingrese el primer año limite: ");
            anioDos = Validaciones.IngresarNum("Ingrese el segundo año limite: ", anioUno);

            Console.WriteLine($"Años bisiestos entre {anioUno} y {anioDos}");
            for (int anio = anioUno; anio <= anioDos; anio++) 
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                    {
                        Console.WriteLine($"{anio}");
                    }
                }
                else if (anio % 4 == 0)
                {
                    Console.WriteLine($"{anio}");
                }
            }
            
            Console.ReadKey();


        }
    }
}