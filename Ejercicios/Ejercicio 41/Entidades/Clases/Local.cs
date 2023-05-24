using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        private float CalcularCosto()
        {
            return costo * Duracion;
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
            return obj is not null && obj is Local;
        }

        public override string ToString()
        {
            return MostrarDatos();
        }
    }
}
