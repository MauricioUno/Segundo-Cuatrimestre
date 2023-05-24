using Entidades.Clases;
using Entidades.Excepciones;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita(" Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", EFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Local l5 = new Local("Desierto", 50, "San Rafael", 2.99f);
            Provincial l4 = new Provincial(EFranja.Franja_3, l2);
            Provincial l6 = new Provincial("Varela", EFranja.Franja_3, 12, "Quilmes");
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c += l1;
            c += l2;
            c += l3;
            try 
            {
                c += l4;
            }catch (CentralitaException ex) 
            {
                Console.WriteLine($"{ex.Message}");
            }
            
            c += l5;
            c += l6;
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());
            Console.ReadKey();
        }
    }
}