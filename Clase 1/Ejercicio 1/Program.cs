namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";
            int numero;
            int acumulador = 0;
            int cantidad = 5;
            float promedio;
            int i = 0;
            int max = int.MaxValue;
            int min = int.MinValue;
            bool validacion;

            Console.WriteLine("Ingrese 5 números enteros");
            do
            {
                Console.WriteLine($"Ingreso n°{i + 1}: ");
                validacion = int.TryParse(Console.ReadLine(), out numero);
                if (validacion)
                {
                    if (max < numero || i == 0)
                    {
                        max = numero;
                    }

                    if (min > numero || i == 0)
                    {
                        min = numero;
                    }

                    acumulador += numero;
                    i += 1;
                }
                else
                {
                    Console.WriteLine("ERROR! Debe ingresar un número entero!");
                }

            } while (i < cantidad);
            promedio = ((float)acumulador / (float)cantidad);
            Console.WriteLine($"El promedio de los numeros ingresados es: {promedio}");
            Console.WriteLine($"El valor maximo ingresado fue: {max}");
            Console.WriteLine($"El valor minimo ingresado fue: {min}");
            Console.ReadKey();

        }
    }
}