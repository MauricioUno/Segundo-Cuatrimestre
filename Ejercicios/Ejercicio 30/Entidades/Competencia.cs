using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia() 
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas): this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Cantidad maxima de competidores: {this.cantidadCompetidores}");
            datos.AppendLine($"Cantidad de vueltas a realizar: {this.cantidadVueltas}");
            datos.AppendLine($"---COMPETIDORES---\n");
            foreach (AutoF1 competidor in this.competidores) 
            {
                datos.AppendLine(competidor.MostrarDatos());
            }
            return datos.ToString();
        }

        public static bool operator ==(Competencia comp, AutoF1 competidor)
        {
            return comp.competidores.Contains(competidor);
        }

        public static bool operator !=(Competencia comp, AutoF1 competidor)
        {
            return !(comp == competidor);
        }

        public static bool operator +(Competencia comp, AutoF1 competidor) 
        {
            if (comp.competidores.Count < comp.cantidadCompetidores && comp != competidor) 
            {

                Random combustible = new Random();
                competidor.SetEnCompetencia(true);
                competidor.SetCantidadCombustible((short)combustible.Next(15,100));
                competidor.SetVueltasRestantes(comp.cantidadVueltas);
                comp.competidores.Add(competidor);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia comp, AutoF1 competidor)
        {
            if (comp == competidor)
            {
                comp.competidores.Remove(competidor);
                return true;
            }
            return false;
        }
    }
}
