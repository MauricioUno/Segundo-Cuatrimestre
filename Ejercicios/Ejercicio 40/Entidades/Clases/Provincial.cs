using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public enum EFranja { Franja_1, Franja_2, Franja_3 }
    public class Provincial : Llamada
    {
        protected EFranja franjaHoraria;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(EFranja franja, Llamada llamada) : this(llamada.NroOrigen, franja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, EFranja franja, float duracion, string destino) : base(duracion, destino, origen)
        {
            franjaHoraria = franja;
        }

        private float CalcularCosto()
        {
            float[] franjas = { 0.99f, 1.25f, 0.66f };
            return franjas[(int)franjaHoraria] * Duracion;
        }
        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Costo de la llamada: {CostoLlamada:0.00}");
            return datos.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Provincial;
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

    }
}
