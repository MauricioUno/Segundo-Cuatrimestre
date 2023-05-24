using Entidades.Modelos;
using Entidades.MetodoDeExtension;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            Conversor c = new Conversor();

            //ASI NO SE USAAAAAA 
            //Console.WriteLine(MetodosDeExtension.CantidadDeLetras("lalalallala"));


            Console.WriteLine(numero.ElevarAlCuadrado());
            Console.WriteLine(c.ExtenderConversor());
            Console.WriteLine("Hello, World!".CantidadDeLetras());

            Console.WriteLine("Hola".Concatenar("Mundo", "Como", "Estas").Concatenar("Otra Cosa"));
        }
    }
}