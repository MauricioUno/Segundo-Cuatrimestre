using Entidades;

namespace Ejercicio14
{
    internal class Ejercicio14
    {
        static void Main(string[] args)
        {
            string figura;
            double medidaUno;
            double medidaDos;
            double area = 0;
            Console.Title = "Ejercicio N°14";
           
            figura = Visualizacion.IngresarTexto("Calcular el area de cuadrado/circulo/triangulo: ", "cuadrado", "circulo", "triangulo");

            switch (figura) 
            {
                case "cuadrado":
                    medidaUno = Visualizacion.IngresarMedida("Ingrese la medida del lado del cuadrado");
                    area = CalculoDeArea.CalcularCuadrado(medidaUno);
                    break;

                case "circulo":
                    medidaUno = Visualizacion.IngresarMedida("Ingrese la medida del radio del circulo");
                    area = CalculoDeArea.CalcularCirculo(medidaUno);
                    break;

                case "triangulo":
                    medidaUno = Visualizacion.IngresarMedida("Ingrese la medida de la base del triangulo");
                    medidaDos = Visualizacion.IngresarMedida("Ingrese la medida de la altura del triangulo");
                    area = CalculoDeArea.CalcularTriangulo(medidaUno, medidaDos);
                    break;
            }

            Console.WriteLine($"La superficie del {figura} es de: {area.ToString("0.00")}");
            Console.ReadKey();
        }

        
    }
}