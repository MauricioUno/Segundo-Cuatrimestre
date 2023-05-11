using Entidades;
namespace Ejercicio_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Negocio neeko = new Negocio("El rallado");
            Cliente c1 = new Cliente(1, ",,,1232");
            Cliente c2 = new Cliente(2, "Thing");
            Cliente c3 = new Cliente(3, "Abc");
            Cliente c4 = new Cliente(4, "Teoa");
            Cliente c5 = new Cliente(4, "chorro");

            neeko.Cliente = c1;
            neeko.Cliente = c2;
            neeko.Cliente = c1;
            neeko.Cliente = c3;
            neeko.Cliente = c4;
            neeko.Cliente = c5;

            while (neeko.ClientesPendientes > 0) 
            {
                Console.WriteLine($"Clientes pendientes: {neeko.ClientesPendientes}");

                Console.WriteLine($"Atendiendo a {neeko.Cliente.Nombre}...");
                if (~neeko)
                {
                    Console.WriteLine("Cliente atendido!\n");
                }
            }
            
        }
    }
}