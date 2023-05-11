namespace Ejercicio_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random eve = new Random();
            List<int> listaNumeros = new List<int>();
            Queue<int> colaNumeros = new Queue<int>();
            Stack<int> pilaNumeros = new Stack<int>();

            int numeroGenerado;

            //Cambiar segun que coleccion se use
            while (pilaNumeros.Count < 10)
            {
                numeroGenerado = eve.Next(-100, 100);
                if (numeroGenerado != 0)
                {
                    pilaNumeros.Push(numeroGenerado); // Aqui tambien-
                }
            }

            
            Console.WriteLine("Lista desordenada: ");
            foreach (int numero in pilaNumeros)
            {
                Console.WriteLine(numero);
            }

            listaNumeros = pilaNumeros.ToList(); // Cambiar segun corresponda
            Console.WriteLine("Lista ordenada positivos decreciente: ");
            listaNumeros.Sort(CriterioDecrecienteInt);
            foreach (int numero in listaNumeros)
            {
                if (numero > 0)
                {
                    Console.WriteLine(numero);
                }

            }

            Console.WriteLine("Lista ordenada negativos creciente: ");
            listaNumeros.Sort(CriterioCrecienteInt);
            foreach (int numero in listaNumeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }

            }

            int CriterioCrecienteInt(int num1, int num2)
            {
                return num1 - num2;
            }

            int CriterioDecrecienteInt(int num1, int num2)
            {
                return num2 - num1;
            }
        }
    }
}