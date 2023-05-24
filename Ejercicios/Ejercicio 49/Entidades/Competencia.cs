using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipoCompetencia {AutoF1, MotoCross };
    public class Competencia<T> where T : VehiculoCarrera, new()
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<T> competidores;
        private ETipoCompetencia tipo;

        public List<T> Competidores 
        {
            get { return this.competidores; }
        }

        private Competencia()
        {
            this.competidores = new List<T>();
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
            foreach (T competidor in this.competidores)
            {
                datos.AppendLine(competidor.MostrarDatos());
            }
            return datos.ToString();
        }

        public static bool operator ==(Competencia<T> comp, T competidor)
        {

            if (competidor.GetType().Name == comp.tipo.ToString())
            {
                foreach (T vehiculo in comp.competidores)
                {
                    if (vehiculo.Equals(competidor))
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", competidor.GetType().ToString(), "Equals");
            }
            
        }

        public static bool operator !=(Competencia<T> comp, T competidor)
        {
            return !(comp == competidor);
        }

        public static bool operator +(Competencia<T> comp, T competidor)
        {
            try
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
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Competencia Incorrecta", ex);
            }
        }

        public static bool operator -(Competencia<T> comp, T competidor)
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
