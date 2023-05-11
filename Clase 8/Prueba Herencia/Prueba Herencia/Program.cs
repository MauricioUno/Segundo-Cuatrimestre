using Entidades;
namespace Prueba_Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Taxi t1 = new Taxi("123ABC", "TheOA", 15, 130);
            Vehiculo v1 = new Vehiculo("123123", "Pigeon", 140.4);

            Console.WriteLine(v1.MostrarDatos());
            Console.WriteLine(t1.MostrarDatos());
        }
    }
}