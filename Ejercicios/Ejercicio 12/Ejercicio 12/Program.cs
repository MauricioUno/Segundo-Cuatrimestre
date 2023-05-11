using Entidades;
namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("Ejericio 12");
            
            bool continuar;
            bool ingresoNumeroUno;
            bool ingresoNumeroDos;
            int primerNum;
            int segundoNum;
            char respuesta;

            do
            {
                Console.Write("Ingrese el primer numero entero: ");
                ingresoNumeroUno = int.TryParse(Console.ReadLine(), out primerNum);
                
                Console.Write("Ingrese el segundo numero entero: ");
                ingresoNumeroDos = int.TryParse(Console.ReadLine(), out segundoNum);

                if (ingresoNumeroUno && ingresoNumeroDos) 
                {
                    Console.WriteLine($"La suma de los dos numeros enteros es {primerNum + segundoNum}");
                }
                else 
                {
                    Console.WriteLine("Error! no se realizo la suma");

                }

                Console.Write("Desea continuar? (S / N): ");
                char.TryParse(Console.ReadLine(),out respuesta);
                continuar = ValidarRespuesta.ValidarS_N(respuesta);

            } while (continuar);
        }
    }
}