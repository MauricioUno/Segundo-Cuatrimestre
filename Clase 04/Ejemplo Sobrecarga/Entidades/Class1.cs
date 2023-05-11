namespace Entidades
{
    public class Calculadora
    {
        private int resultado;
        public int Sumar(int num, int numDos) 
        {
            return num + numDos;
        }

        public int Sumar(int num, int numDos, int numTres)
        {
            return this.Sumar(num, numDos) + numTres;
        }
    }
}