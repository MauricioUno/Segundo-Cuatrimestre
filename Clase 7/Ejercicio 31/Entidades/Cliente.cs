using System.Text.RegularExpressions;
namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public string Nombre 
        {
            get { return this.nombre; }
            set 
            {
                Regex regExNombre = new Regex("^[A-Za-z ]+$");
                if (regExNombre.IsMatch(value))
                {
                    this.nombre = value;
                }
                else 
                {
                    this.nombre = "N/A";
                }
               
            }
        }

        public int Numero 
        {
            get { return this.numero; } 
        }

        public Cliente(int numero) 
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre): this(numero)
        {
            this.Nombre = nombre;
        }

        public static bool operator ==(Cliente a, Cliente b) 
        {
            return a.Numero == b.Numero;
        }

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }
    }
}