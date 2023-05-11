namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";
            int contador = 0;
            int numero = 1;
            int divisor;
            int acumulador;

            while (contador < 4)
            {
                acumulador = 0;
                for (divisor = 1; divisor < numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        acumulador += divisor;
                    }
                }
                if (acumulador == numero)
                {
                    Console.WriteLine(numero);
                    contador += 1;
                }
                numero += 1;
            }

            Console.ReadKey();
        }
    }
}