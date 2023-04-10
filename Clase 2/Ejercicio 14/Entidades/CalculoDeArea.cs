using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double numLado) 
        {
            double areaCuadrado = Math.Pow(numLado, 2);

            return areaCuadrado;
            
        }

        public static double CalcularTriangulo(double numBase, double numAltura) 
        {
            double areaTriangulo = (numBase * numAltura) / 2;
            return areaTriangulo;
        }
            
        public static double CalcularCirculo(double numRadio) 
        {
            double areaCirculo = Math.PI * Math.Pow(numRadio,2);
            return areaCirculo;
        }
    }
}
