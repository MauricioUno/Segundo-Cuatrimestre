using Clases;

namespace Ejercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";
            Alumno conejilloUno = new Alumno("Sylvester", "Stallone", 114054);
            Alumno conejilloDos = new Alumno("Evelyn", "Von Brocke", 115090);
            Alumno conejilloTres = new Alumno("Frank", "Suarez", 100052);

            conejilloUno.Estudiar(6, 8);
            Console.WriteLine(conejilloUno.Mostrar());

            conejilloDos.Estudiar(1, 3);
            Console.WriteLine(conejilloDos.Mostrar());

            conejilloTres.Estudiar(10, 10);
            Console.WriteLine(conejilloTres.Mostrar());
            Console.ReadKey();
        }
    }
}