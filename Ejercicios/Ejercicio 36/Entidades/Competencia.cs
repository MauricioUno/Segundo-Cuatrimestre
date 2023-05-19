using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoCompetencia {F1, MotoCross };
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoCarrera> competidores;
        private ETipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoCarrera>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, ETipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Cantidad maxima de competidores: {this.cantidadCompetidores}");
            datos.AppendLine($"Cantidad de vueltas a realizar: {this.cantidadVueltas}");
            datos.AppendLine($"---COMPETIDORES---\n");
            foreach (VehiculoCarrera competidor in this.competidores)
            {
                datos.AppendLine(competidor.MostrarDatos());
            }
            return datos.ToString();
        }

        public static bool operator ==(Competencia comp, VehiculoCarrera competidor)
        {
            return comp.competidores.Contains(competidor);
        }

        public static bool operator !=(Competencia comp, VehiculoCarrera competidor)
        {
            return !(comp == competidor);
        }

        public static bool operator +(Competencia comp, VehiculoCarrera competidor)
        {
            if ((comp.tipo == ETipoCompetencia.F1 && competidor is AutoF1) || (comp.tipo == ETipoCompetencia.MotoCross && competidor is MotoCross)) 
            {
                if (comp.competidores.Count < comp.cantidadCompetidores && comp != competidor)
                {
                    Random combustible = new Random();
                    competidor.EnCompetencia = true;
                    competidor.CantidadCombustible = (short)combustible.Next(15, 100);
                    competidor.VueltasRestantes = comp.cantidadVueltas;
                    comp.competidores.Add(competidor);
                    return true;
                }
            }
            return false;
        }

        public static bool operator -(Competencia comp, VehiculoCarrera competidor)
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
