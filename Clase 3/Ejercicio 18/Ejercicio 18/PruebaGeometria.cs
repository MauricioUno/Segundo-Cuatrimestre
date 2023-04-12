using Geometria;

namespace PruebaGeometria
{
    internal class PruebaGeometria
    {
        static void Main(string[] args)
        {
            Punto verticeUno = new Punto(0, 10);
            Punto verticeTres = new Punto(6, 3);
            Rectangulo myRect = new Rectangulo(verticeUno, verticeTres);
            //myRect.GetArea();
            //myRect.GetPerimetro();

            myRect.MostrarDatos();
        }
    }
}