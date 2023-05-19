using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local: Llamada
    {
        protected float costo;

        public float CostoLlamada 
        {
            get 
            {
                return this.CalcularCosto();
            }
        }

        public Local(Llamada llamada, float costo): this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo): base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto() 
        {
            return this.costo * this.Duracion;
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
