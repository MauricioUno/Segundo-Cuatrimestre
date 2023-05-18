using Entidades.Exceptions;
using Entidades.Models;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora;
            string numeroA;
            string numeroB;

            Console.Write("Ingrese el primer numero: ");
            numeroA = Console.ReadLine();
            Console.Write("Ingrese el segundo numero: ");
            numeroB = Console.ReadLine();

            try
            {
                calculadora = new Calculadora(numeroA, numeroB);
                Console.WriteLine($"El resultado de dividir es {calculadora.Dividir()}");
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (FormatException ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            catch (Exception ex1)
            {
                Console.WriteLine(ex1.Message);
            }
            finally 
            {
                Console.WriteLine("ME EJECUTO SIEMPRE!!!"); // Incluso con un return, esto siempre se ejecutara
            }



            //Mamuschka
            //Exception e = new Exception("Primera excepción");
            //ArgumentoInvalidoException a = new ArgumentoInvalidoException("Evelyn A", e);
            //ArgumentoInvalidoException b = new ArgumentoInvalidoException("Leila B", a);
            //ArgumentoInvalidoException c = new ArgumentoInvalidoException("Katsu C", b);

            //Console.WriteLine(c.Message);
            //Exception bucle = c.InnerException;
            //while(bucle != null) 
            //{
            //    Console.WriteLine(bucle.Message);
            //    bucle = bucle.InnerException;
            //}
        }
    }
}