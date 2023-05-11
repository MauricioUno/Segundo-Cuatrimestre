using Entidades;
namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 7";
            int anio;
            int mes;
            int dia;

            anio = Validaciones.IngresarNum("Ingrese el año de nacimiento: ", 1, (int)DateTime.Now.Year);
            mes = Validaciones.IngresarNum("Ingrese el mes de nacimiento: ", 1, 12);
            dia = Validaciones.IngresarNum("Ingrese el dia de nacimiento", 1, DateTime.DaysInMonth(anio, mes));
            DateTime fechaNacimiento = new DateTime(anio, mes, dia);
            TimeSpan diasVividos = (DateTime.Now - fechaNacimiento);
            Console.WriteLine($"Dias vividos: {diasVividos.TotalDays:.00}");
        }
    }
}