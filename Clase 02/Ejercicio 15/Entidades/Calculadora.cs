using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        public static double? Calcular(double num1, double num2, char operacion) 
        {
            double? resultado = null;
            switch (operacion) 
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                case '/':
                    if (Calculadora.Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    break;
            }
            return resultado;

        }

        private static bool Validar(double numero) 
        {
            return (numero != 0);
        }
    }
}
