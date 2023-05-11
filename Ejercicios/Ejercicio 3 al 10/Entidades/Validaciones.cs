using System.Text.RegularExpressions;

namespace Entidades
{
    public static class Validaciones
    {
        public static int IngresarNum(string mensaje, int mininmo = int.MinValue, int maximo = int.MaxValue) 
        {
            int numeroIngresado;
            while (true)
            {
                Console.WriteLine(mensaje);
                int.TryParse(Console.ReadLine(), out numeroIngresado);
                if (ValidarRango(numeroIngresado, mininmo, maximo))
                {
                    Console.WriteLine("Valor ingresado!");
                    return numeroIngresado;
                }
                else
                {
                    Console.WriteLine("Error! Valor ingresado no valido!");
                }
            }
        }

        private static bool ValidarRango(int num, int min, int max)
        {
            if (max < min) 
            {
                IntercambiarValores(ref max, ref min);
            }
            return (num >= min && num <= max);
        }

        private static void IntercambiarValores(ref int numUno, ref int numDos) 
        {
            int aux;
            aux = numUno;
            numUno = numDos;
            numDos = aux;
        }

        public static bool ValidarS_N(char caracter)
        {
            return caracter == 'S';

        }

    }
}
