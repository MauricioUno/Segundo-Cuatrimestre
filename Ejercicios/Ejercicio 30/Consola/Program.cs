using Entidades;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Competencia copaPiston = new Competencia(3, 10);
            AutoF1 mcQueen = new AutoF1(95, "Rayo");
            AutoF1 emmet = new AutoF1(15, "Delorean");
            AutoF1 gato = new AutoF1(26, "Katsu");
            AutoF1 jordi = new AutoF1(75, "Wild");

            Console.WriteLine(copaPiston + mcQueen);
            Console.WriteLine(copaPiston + emmet);
            Console.WriteLine(copaPiston + gato);
            Console.WriteLine(copaPiston + jordi);
            Console.WriteLine(copaPiston.MostrarDatos());

            Console.WriteLine(copaPiston - gato);
            Console.WriteLine(copaPiston + jordi);
            Console.WriteLine(copaPiston.MostrarDatos());
        }
    }
}