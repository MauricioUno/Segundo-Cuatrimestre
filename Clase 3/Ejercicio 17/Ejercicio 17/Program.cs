using Entidades;

namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona pez = new Persona("Mauricio", "Uno", 20);
            //Perro violeta = new Perro("Violeta", 6, pez);
            //Console.WriteLine(violeta.Saludar());
            Console.Title = "Ejercicio N°17";
            string dibujo;
            bool utilizado;

            Boligrafo boligrafoUno = new Boligrafo(ConsoleColor.Blue, 100);
            //Boligrafo boligrafoDos = new Boligrafo(ConsoleColor.Red, 50);
            
            utilizado = boligrafoUno.Pintar(120, out dibujo);
            if (utilizado)
            {
                Console.WriteLine("Se utilizaron las siguientes unidades de tinta: ");
                Console.ForegroundColor = boligrafoUno.GetColor();
                Console.WriteLine(dibujo);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else 
            {
                Console.WriteLine("No queda tinta para utilizar! Recargue la tinta");
            }
            Console.ReadKey();  
            
            
            
            
        }

    }
}