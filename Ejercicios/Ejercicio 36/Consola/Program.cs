using Entidades;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia copaPiston = new Competencia(3, 10, ETipoCompetencia.F1);
            MotoCross mcQueen = new MotoCross(95, "Rayo",3);
            MotoCross emmet = new MotoCross(15, "Delorean",5);
            AutoF1 gato = new AutoF1(75, "Katsu", 4);
            AutoF1 jordi = new AutoF1(75, "Katsu", 2);

            Console.WriteLine(copaPiston + mcQueen); // false
            Console.WriteLine(copaPiston + emmet); // false
            Console.WriteLine(copaPiston + gato); // true
            Console.WriteLine(copaPiston + jordi); // true
            Console.WriteLine(jordi == gato); // false

            Console.WriteLine(copaPiston.MostrarDatos());
        }
    }
}