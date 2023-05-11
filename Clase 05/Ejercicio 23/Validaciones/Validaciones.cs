using System.Text.RegularExpressions;
namespace Entidades
{
    public static class Validaciones
    {
        public static bool StringIsNumber(string texto) 
        {
            string regEx = @"^[+-]?[0-9]+([\,\.]?[0-9]+)?$";
            if (Regex.IsMatch(texto, regEx))
            {
                return true;
            }
            return false;
            
        }

        public static double StringToDouble(string texto) 
        {
            double numero;

            texto = Regex.Replace(texto, @"\.", ",");
            double.TryParse(texto, out numero);    
            
            return numero;
        }

        public static bool StringIsPositive(string texto)
        {
            return StringIsNumber(texto) && StringToDouble(texto) > 0;
    }


    }
}