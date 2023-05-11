namespace Entidades
{
    public class Vehiculo
    {
        protected string matricula;
        protected string modelo;
        protected double potenciaCV;

        public Vehiculo(string matricula, string modelo, double potenciaCV)
        {
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.PotenciaCV = potenciaCV;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double PotenciaCV { get => potenciaCV; set => potenciaCV = value; }

        public virtual string MostrarDatos() 
        {
            string mensaje = $"Modelo: {this.Modelo} Matricula: {this.Matricula} Potencia: {this.PotenciaCV} ";
            return mensaje;
        }
    }
}