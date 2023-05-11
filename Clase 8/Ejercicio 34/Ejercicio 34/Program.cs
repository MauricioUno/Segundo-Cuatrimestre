using Entidades;
 namespace Ejercicio_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 34";
            VehiculoTerrestre vehiculoTest = new VehiculoTerrestre(2,1,EColores.Blanco);
            VehiculoTerrestre moto = new Moto(3, 3, EColores.Gris, 3);
            Automovil pipo = new Automovil(4, 5, EColores.Negro, 6, 2);
            Camion plantas = new Camion(8, 2, EColores.Rojo, 6, 10000);

            Console.WriteLine(vehiculoTest.MostrarDatos());
            Console.WriteLine(moto.MostrarDatos());
            Console.WriteLine(pipo.MostrarDatos());
            Console.WriteLine(plantas.MostrarDatos());
        }
    }
}