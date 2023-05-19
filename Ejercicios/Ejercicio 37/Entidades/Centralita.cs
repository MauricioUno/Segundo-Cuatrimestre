using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciaPorLocal
        {
            get 
            {
                return this.CalcularGanancia(EtipoLLamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get 
            {
                return this.CalcularGanancia(EtipoLLamada.Provincial);
            }
        }
        public float GananciaPorTotal
        {
            get 
            {
                return this.CalcularGanancia(EtipoLLamada.Todas);
            }
        }

        public List<Llamada> Llamadas 
        {
            get 
            {
                return this.listaDeLlamadas;
            }
        }

        public Centralita() 
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa): this() 
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(EtipoLLamada tipo) 
        {
            float gananciaTotal = 0;
            if (tipo == EtipoLLamada.Local || tipo == EtipoLLamada.Todas)
            {
                foreach (Llamada llamada in this.listaDeLlamadas)
                {
                    if (llamada is Local)
                    {
                        gananciaTotal += ((Local)llamada).CostoLlamada;
                    }
                }
            }
            if (tipo == EtipoLLamada.Provincial || tipo == EtipoLLamada.Todas)
            {
                foreach (Llamada llamada in this.listaDeLlamadas)
                {
                    if (llamada is Provincial)
                    {
                        gananciaTotal += ((Provincial)llamada).CostoLlamada;
                    }
                }
            }
            return gananciaTotal;
        }

        public string MostrarDatos() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Razon Social: {this.razonSocial}");
            datos.AppendLine($"Ganancia Total: {this.GananciaPorTotal}");
            datos.AppendLine($"Ganancia Provincial: {this.GananciaPorProvincial}");
            datos.AppendLine($"Ganancia Local: {this.GananciaPorLocal}");
            datos.AppendLine($"---Lista de llamadas---\n");
            foreach (Llamada llamada in this.Llamadas) 
            {
                datos.AppendLine(llamada.MostrarDatos());
            }

            return datos.ToString();
        }

        public void OrdenarLlamadas() 
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
