using Entidades;
using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita(" Fede Center");
            // Mis 4 llamadas
            Local l1 = new Local("Bernal",30,"Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", EFranja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Local l5 = new Local("Desierto", 50, "San Rafael", 2.99f);
            Provincial l4 = new Provincial(EFranja.Franja_3, l2);
            Provincial l6 = new Provincial("Varela",EFranja.Franja_3, 12, "Quilmes");
            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c.Llamadas.Add(l1);
            c.Llamadas.Add(l2);
            c.Llamadas.Add(l3);
            c.Llamadas.Add(l4);
            c.Llamadas.Add(l5);
            c.Llamadas.Add(l6);
            c.OrdenarLlamadas();
            Console.WriteLine(c.MostrarDatos());
            Console.ReadKey();
        }
    }
}