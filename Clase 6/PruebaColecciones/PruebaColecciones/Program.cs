using System.Collections.Generic;
using Entidades;
namespace PruebaColecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> edad = new List<int>();

            //Console.WriteLine(edad.Count);
            //edad.Add(1);
            //Console.WriteLine(edad.Count);

            

            //Persona p1 = new Persona(10, "Thiago", "Vilani");
            //Persona p2 = new Persona(32, "Andrea", "Morge");
            //Persona p3 = new Persona(23, "Evelin", "Zilovaef");

            //List<Persona> lista = new List<Persona>() { p1, p2, p3};

            //foreach (Persona p in lista) 
            //{
            //    Console.WriteLine(p.Saludar());
            //}

            //lista.Remove(p1);
            //Console.WriteLine("Segundo saludo");
            //foreach (Persona p in lista)
            //{
            //    Console.WriteLine(p.Saludar());
            //}


            //lista.Sort(CriterioEdad);

            //Console.WriteLine("Tercer saludo");
            //foreach (Persona p in lista)
            //{
            //    Console.WriteLine(p.Saludar());
            //}


            //lista.Sort(CriterioNombre);

            //Console.WriteLine("Cuarto saludo");
            //foreach (Persona p in lista)
            //{
            //    Console.WriteLine(p.Saludar());
            //}

            //int CriterioEdad(Persona ppl1, Persona ppl2) 
            //{
            //    return ppl1.getEdad() - ppl2.getEdad();
            //}

            //int CriterioNombre(Persona ppl1, Persona ppl2) 
            //{
            //    return String.Compare(ppl1.getNombre(), ppl2.getNombre());
            //}

            //Queue <int> cola = new Queue<int> ();
            //cola.Enqueue(1);
            //cola.Enqueue(2);
            //cola.Enqueue (3);
            //cola.Enqueue(4);
            //Console.WriteLine($"Recupero elemento y no lo elimino {cola.Peek()}"); // Recupera el primero que esta en la cola
            //Console.WriteLine($"Cantidad: {cola.Count}");
            //Console.WriteLine ("Removido: {0}", cola.Dequeue());
            //Console.WriteLine($"Cantidad: {cola.Count}");

            //foreach (int elemento in cola) 
            //{
            //    Console.WriteLine(elemento);
            //}

            Stack <int> hamburguer = new Stack<int> ();
            hamburguer.Push (1);
            hamburguer.Push (2);
            hamburguer.Push (3);
            foreach (int ñam in hamburguer) 
            {
                Console.WriteLine(ñam);
            }

            Console.WriteLine($"Elemento removido: {hamburguer.Pop()}");
            foreach (int ñam in hamburguer)
            {
                Console.WriteLine(ñam);
            }

            // No se puede usar con objetos clases,

            SortedList<int, string> sortedList = new SortedList<int, string> ();
            sortedList.Add(90, "Hola");
            sortedList.Add(1, "Hello!");
            sortedList.Add(150, "TheOA!");
            foreach (var elemento in sortedList) 
            {
                Console.WriteLine(elemento.Key);
                Console.WriteLine(elemento.Value);
            }
        }
    }
}