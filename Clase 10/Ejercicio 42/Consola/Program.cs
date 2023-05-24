using Entidades;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtraClase excepcion = new OtraClase();
            try 
            {
                excepcion.InstanciarMiClase();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                while (ex.InnerException != null) 
                {
                    ex = ex.InnerException;
                    Console.WriteLine(ex.Message);
                    
                }
            }
        }
    }
}