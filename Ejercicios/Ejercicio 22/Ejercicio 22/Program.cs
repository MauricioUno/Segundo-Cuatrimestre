using Entidades;
namespace Ejercicio_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            NumeroBinario binario = "5";
            NumeroDecimal decimel = 3;
            Console.WriteLine(binario + decimel);
            Console.WriteLine(binario == decimel);
            Console.WriteLine(binario != decimel);
            Console.WriteLine(decimel + binario);
            Console.WriteLine(decimel - binario);
            Console.WriteLine(decimel == binario);

            //Agregar a la conversion la representacion de numeros binarios negativos!
            Console.WriteLine(binario - decimel);
            
        }
    }
}