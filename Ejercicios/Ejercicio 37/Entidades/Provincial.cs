using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EFranja { Franja_1, Franja_2, Franja_3 }
    public class Provincial : Llamada
    {
        protected EFranja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(EFranja franja, Llamada llamada) : this(llamada.NroOrigen, franja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, EFranja franja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = franja;
        }

        private float CalcularCosto()
        {
            float[] franjas = {0.99f, 1.25f, 0.66f};
            return franjas[(int)this.franjaHoraria] * this.Duracion;
        }
        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Costo de la llamada: {this.CostoLlamada}");
            return datos.ToString();
        }

    }
}
