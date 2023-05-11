using Entidades;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(3,4));
            Console.WriteLine(calculadora.Sumar(5,5,2));
        }
    }
}