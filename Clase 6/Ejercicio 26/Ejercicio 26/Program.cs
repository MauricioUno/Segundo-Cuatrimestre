namespace Ejercicio_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random eve = new Random();
            int[] matrizNumero = new int[20];
            int numeroGenerado;
            int indice = 0;

            while (indice < matrizNumero.Length) 
            {
                numeroGenerado = eve.Next(-100, 100);
                if (numeroGenerado != 0)
                {
                    matrizNumero[indice] = numeroGenerado;
                    indice += 1;
                }
            }

            Console.WriteLine("Lista desordenada: ");
            foreach (int numero in matrizNumero) 
            {
                Console.WriteLine(numero);
            }


            Console.WriteLine("Lista ordenada positivos decreciente: ");
            Array.Sort(matrizNumero);
            Array.Reverse(matrizNumero);
            foreach (int numero in matrizNumero) 
            {
                if (numero > 0) 
                {
                    Console.WriteLine(numero);
                }
                
            }

            Console.WriteLine("Lista ordenada negativos creciente: ");
            Array.Sort(matrizNumero);
            
            foreach (int numero in matrizNumero)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }

            }

        }
    }
}