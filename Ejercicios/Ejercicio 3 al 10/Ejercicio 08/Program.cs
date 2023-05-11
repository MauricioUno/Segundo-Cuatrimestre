using Entidades;
namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 8";
            int valorHora;
            string nombre;
            byte antiguedad;
            short horasTrabajadas;
            double reciboBruto;
            double descuento;
            double reciboTotal;
            bool continuar;
            char respuesta;

            do
            {
                Console.Write("Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();
                antiguedad = (byte)Validaciones.IngresarNum("Ingrese la antiguedad del empleado en años: ", 1, 100);
                horasTrabajadas = (short)Validaciones.IngresarNum("Ingrese la cantidad de horas trabajadas por mes: ", 1, 1000);
                valorHora = Validaciones.IngresarNum("Ingrese el pago por hora", 1);

                reciboBruto = valorHora * horasTrabajadas + antiguedad * 150;
                descuento = reciboBruto * 13 / 100;
                reciboTotal = reciboBruto - descuento;
                Console.WriteLine($"Empleado: {nombre}");
                Console.WriteLine($"Años de antiguedad: {antiguedad}");
                Console.WriteLine($"Pago por hora: {valorHora}");
                Console.WriteLine($"Pago bruto: {reciboBruto:.00}");
                Console.WriteLine($"Descuento: {descuento:.00}");
                Console.WriteLine($"Pago neto: {reciboTotal:.00}");

                Console.Write("Desea continuar? (S / N): ");
                char.TryParse(Console.ReadLine(), out respuesta);
                continuar = Validaciones.ValidarS_N(respuesta);


            } while (continuar);

            




        }
    }
}