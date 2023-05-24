using Entidades;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia comp = new Competencia(3, 10, ETipoCompetencia.AutoF1);
            MotoCross moto = new MotoCross(95, "Rayo", 3);
            AutoF1 gato = new AutoF1(8, "Coco", 2);
            AutoF1 perro = new AutoF1(5, "Violeta", 2);

            try 
            {
                Console.WriteLine(comp + moto); // Excepcion; el competidor no puede participar en esta competencia
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"{ex.Message}");
                Console.WriteLine($"{ex.InnerException}");
            }
           
            Console.WriteLine(comp + gato); // true; se agrega el competidor a la competencia
            Console.WriteLine(comp + perro); // true

            Console.WriteLine(comp.MostrarDatos());
        }
    }
}