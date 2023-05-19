using System.Text;

namespace Entidades
{
    public enum EtipoLLamada {Local, Provincial, Todas}
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen) 
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public virtual string MostrarDatos() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Origen: {this.nroOrigen}");
            datos.AppendLine($"Destino: {this.nroDestino}");
            datos.AppendLine($"Duracion: {this.duracion}");
            return datos.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos) 
        {
            return (int)(llamadaUno.Duracion - llamadaDos.Duracion);
        }


    }
}