using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Validaciones
    {
        public static bool ValidarTexto(string textoIngresado, params string[] valores){
            bool validacion = false;
            if (valores.Contains(textoIngresado))
            {
                validacion = true;
            }
            return validacion;    
        }

        public static bool ValidarNumPositivo(double numero) 
        {
            bool validacion = false;
            if (numero > 0) {
                validacion = true;
            }
                return validacion;
        }
    }
}
