using Entidades;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            Rectangulo myRect = new Rectangulo(7.5,10);
            Cuadrado mySqr = new Cuadrado(8.5);
            Circulo myCrl = new Circulo(3);
            figuras.Add(myRect);
            figuras.Add(mySqr);
            figuras.Add(myCrl);

            foreach (Figura figura in figuras) 
            {
                Console.WriteLine($"===== FIGURA =====");
                Console.WriteLine($"Tipo: {figura.GetType()}");
                Console.WriteLine($"{figura.Dibujar()}");
                Console.WriteLine($"Area: {figura.CalcularSuperficie():0.00}");
                Console.WriteLine($"Perimetro: {figura.CalcularPerimetro():0.00}");
                Console.WriteLine($"==================\n");
            }
        }
    }
}