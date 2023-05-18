using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Calculadora
    {
        private int numeroA;
        private int numeroB;
        public Calculadora(string numeroA, string numeroB) 
        {
            this.ConvierteNumero(numeroA, out this.numeroA);
            this.ConvierteNumero(numeroB, out this.numeroB);
        }

        public double Dividir() 
        {
            try
            {
                return this.numeroA / this.numeroB;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Error al dividir {e.Message}");
                return -1;
            }
                 
        }

        public double Multiplicar()
        {
            return this.numeroA * this.numeroB;
        }

        public double Sumar()
        {
            return this.numeroA + this.numeroB;
        }

        public double Restar()
        {
            return this.numeroA - this.numeroB;
        }

        private bool ConvierteNumero(string numero, out int resultado)
        {
            bool retorno;
            try
            {
                resultado = int.Parse(numero);
                Console.WriteLine("No hay error");
                retorno = true;
            }
            catch (Exception e) 
            {
                resultado = 0;
                Console.WriteLine("Hay error");
                retorno = false;
            }
            Console.WriteLine("Fin del metodo");
            return retorno;
        }

        
    }
}
