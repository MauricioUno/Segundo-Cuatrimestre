
namespace Clases
{
    public class Alumno
    {
        private byte notaUno;
        private byte notaDos;
        private float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar(byte notaUno, byte notaDos) 
        {
            this.notaUno = notaUno;
            this.notaDos = notaDos;
        }

        public void CalcularFinal() 
        {
            if (this.notaUno >= 4 && this.notaDos >= 4)
            {
                this.notaFinal = new Random().Next(11);
            }
            else 
            {
                this.notaFinal = -1;
            }
        }

        public string Mostrar() 
        {
            string datos;
            string parciales;
            string final;
            string mensaje;

            datos = $"Alumno: {this.nombre} {this.apellido}\nNro Legajo: {this.legajo}";
            parciales = $"Nota 1er Parcial: {this.notaUno}\nNota 2do Parcial: {this.notaDos}";
            this.CalcularFinal();
            if (this.notaFinal != -1)
            {
                final = $"Nota Final: {this.notaFinal}";
            }
            else 
            {
                final = $"Alumno Desaprobado";
            }
            mensaje = string.Concat(datos, "\n", parciales, "\n", final, "\n");
            return mensaje;
        }
    }
}