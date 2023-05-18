using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosDeExtension
    {
        public static bool IsNumber(this string texto)
        {
            string regEx = @"^[+-]?[0-9]+([\,\.]?[0-9]+)?$";
            if (Regex.IsMatch(texto, regEx))
            {
                return true;
            }
            return false;

        }

        public static double ToDouble(this string texto)
        {
            double numero;

            texto = Regex.Replace(texto, @"\.", ",");
            double.TryParse(texto, out numero);

            return numero;
        }
    }
}
