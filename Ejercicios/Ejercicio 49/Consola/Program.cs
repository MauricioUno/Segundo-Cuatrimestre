using Entidades;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia<AutoF1> comp = new Competencia<AutoF1>(3, 10, ETipoCompetencia.AutoF1);
            MotoCross moto = new MotoCross(95, "Rayo", 3);
            AutoF1 gato = new AutoF1(8, "Coco", 2);
            AutoF1 perro = new AutoF1(5, "Violeta", 2);

            try
            {
                //Console.WriteLine(comp + moto); //Ya no permite realizar la operacion
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