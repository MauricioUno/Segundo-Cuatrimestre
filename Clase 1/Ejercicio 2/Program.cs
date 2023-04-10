namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2";

            double numero;
            double cuadrado;
            double cubo;

            do 
            {
                Console.WriteLine($"Ingrese un numero mayor a cero: ");
                double.TryParse(Console.ReadLine(), out numero);
                if (numero > 0)
                {
                    cuadrado = Math.Pow(numero, 2);
                    cubo = Math.Pow(numero, 3);
                    break;
                }
                else 
                {
                    Console.WriteLine($"ERROR! Reingresar Numero!");
                }
            }while (true);

            Console.WriteLine($"Cuadrado del numero: {cuadrado.ToString("0.00")}");
            Console.WriteLine($"Cubo del numero: {cubo.ToString("0.00")}");
            Console.ReadKey();
        }
    }
}