using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutoF1: VehiculoCarrera
    {
        private short caballoFuerza;

        #region Propiedades
        public short CaballoFuerza 
        {
            get 
            {
                return this.caballoFuerza;
            }
            set 
            {
                if (value > 0) 
                {
                    this.caballoFuerza = value;
                }
            }
        }
        #endregion

        #region Constructores
        public AutoF1(short numero, string escuderia): base(numero, escuderia)
        {
        }

        public AutoF1(short numero, string escuderia, short caballoDeFuerza) : this(numero, escuderia) 
        {
            this.CaballoFuerza = caballoDeFuerza;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(AutoF1 a, AutoF1 b) 
        {
            return (VehiculoCarrera)a == (VehiculoCarrera)b && a.CaballoFuerza == b.CaballoFuerza;
        }

        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return !(a == b);
        }
        #endregion

        #region Metodos
        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Caballos de fuerza: {this.CaballoFuerza}");

            return datos.ToString();
        }
        public override bool Equals(object? obj)
        {
            return (obj is not null && obj is AutoF1 && (AutoF1)obj == this);
        }
        #endregion
    }
}
