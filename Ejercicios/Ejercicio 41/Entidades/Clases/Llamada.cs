using System.Text;

namespace Entidades.Clases
{
    public enum EtipoLLamada { Local, Provincial, Todas }
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract float CostoLlamada { get; }

        public float Duracion
        {
            get
            {
                return duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public static bool operator ==(Llamada llamadaUno, Llamada llamadaDos)
        {
            return llamadaUno.Equals(llamadaDos) && llamadaUno.nroDestino == llamadaDos.nroDestino && llamadaUno.nroOrigen == llamadaDos.nroOrigen;
        }

        public static bool operator !=(Llamada llamadaUno, Llamada llamadaDos)
        {
            return !(llamadaUno == llamadaDos);
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Origen: {nroOrigen}");
            datos.AppendLine($"Destino: {nroDestino}");
            datos.AppendLine($"Duracion: {duracion}");
            return datos.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
        {
            return (int)(llamadaUno.Duracion - llamadaDos.Duracion);
        }


    }
}