using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;
namespace Entidades.Clases
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(EtipoLLamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return CalcularGanancia(EtipoLLamada.Provincial);
            }
        }
        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(EtipoLLamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
            }
        }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(EtipoLLamada tipo)
        {
            float gananciaTotal = 0;
            if (tipo == EtipoLLamada.Local || tipo == EtipoLLamada.Todas)
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if (llamada is Local)
                    {
                        gananciaTotal += ((Local)llamada).CostoLlamada;
                    }
                }
            }
            if (tipo == EtipoLLamada.Provincial || tipo == EtipoLLamada.Todas)
            {
                foreach (Llamada llamada in listaDeLlamadas)
                {
                    if (llamada is Provincial)
                    {
                        gananciaTotal += ((Provincial)llamada).CostoLlamada;
                    }
                }
            }
            return gananciaTotal;
        }

        private string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Nombre Empresa: {razonSocial}");
            datos.AppendLine($"---Lista de llamadas---\n");
            foreach (Llamada llamada in Llamadas)
            {
                datos.AppendLine(llamada.ToString());
            }

            return datos.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }

        public void OrdenarLlamadas()
        {
            Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }

        public static bool operator ==(Centralita central, Llamada llamada)
        {
            foreach (Llamada llamadaAux in central.listaDeLlamadas)
            {
                if (llamadaAux == llamada)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita central, Llamada llamada)
        {
            return !(central == llamada);
        }

        public static Centralita operator +(Centralita central, Llamada llamada)
        {
            if (central != llamada)
            {
                central.AgregarLlamada(llamada);
            }
            else 
            {
                throw new CentralitaException("La llamada ya se encuentra registrada en el sistema");
            }
            return central;
        }
    }
}
