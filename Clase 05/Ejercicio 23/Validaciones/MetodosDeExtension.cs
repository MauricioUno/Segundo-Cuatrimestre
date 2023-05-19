using System.Text.RegularExpressions;
namespace Entidades
{
    public static class MetodosDeExtension
    {
        public static bool IsDecimal(this string texto) 
        {
            string regEx = @"^[0-9]+([\,\.]?[0-9]+)?$";
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