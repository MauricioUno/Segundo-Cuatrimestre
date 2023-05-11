using Clases;
namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento miEstacionamiento = Estacionamiento.GetEstacionamiento("24HS", 5);
            Vehiculo[] vehiculos = { new Automovil("IZO718", new DateTime(2023, 5, 4, 10, 40, 0), "Ford"),
                new Automovil("EPX277", new DateTime(2023, 5, 4, 9, 40, 0), "Chevrolet"),
                new Automovil("IDW900", new DateTime(2023, 5, 4, 6, 40, 0), "VolksWagen"),
                // new Automovil("IDW900", new DateTime(2023, 5, 4, 3, 40, 0), "VolksWagen"),
                new Moto("LDP123", new DateTime(2023, 5, 4, 1, 40, 0), Moto.Etipo.Scooter),
                // new Moto("JUY866", new DateTime(2023, 5, 4, 12, 40, 0), Moto.Etipo.Ciclomotor),
                new Moto("AAA999", new DateTime(2023, 5, 3, 13, 40, 0), Moto.Etipo.Sport)};

            foreach (Vehiculo item in vehiculos)
            {
                if (miEstacionamiento + item)
                {
                    Console.WriteLine($"Se agrego: \n{item.ToString()}");
                }
                else
                {
                    Console.WriteLine($"No se pudo agregar: \n{item.ToString()}");
                }
            }
            Console.ReadKey();
            Console.Clear();
            foreach (Vehiculo item in vehiculos)
            {
                if (miEstacionamiento - item)
                {
                    Console.WriteLine($"{miEstacionamiento.InformarSalida(item)}");
                }
                else
                {
                    Console.WriteLine($"No se pudo retirar: \n{item.ToString()}");
                }
            }




            Console.ReadKey();
        }
    }
}