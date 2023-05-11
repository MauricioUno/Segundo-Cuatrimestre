namespace Entidades
{
    public class Persona
    {
        public static string familia;
        public int edad;
        public string nombre;
        public string apellido;

        static Persona() 
        {
            Persona.familia = "Homo Sapiens";
        }
        public Persona(string nombre, string apellido, int edad) 
        {
            this.nombre = nombre; 
            this.apellido = apellido;
            this.edad = edad;
        }

        public static void CambiarFamilia(string familia) 
        {
            Persona.familia = familia;
        }
    }
}