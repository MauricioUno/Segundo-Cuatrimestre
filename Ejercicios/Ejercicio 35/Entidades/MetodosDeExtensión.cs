using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodosDeExtensión
    {
        public static bool IsAlphaNumeric(this string texto)
        {
            string regEx = @"^[0-9A-Za-z ]+$";
            return Regex.IsMatch(texto, regEx);
        }

        public static bool IsInteger(this string texto)
        {
            string regEx = @"^[0-9]+$";
            return Regex.IsMatch(texto, regEx);
        }

        public static int ToInt(this string texto) 
        {
            int numero;
            int.TryParse(texto, out numero);
            return numero;
        }

    }
}
