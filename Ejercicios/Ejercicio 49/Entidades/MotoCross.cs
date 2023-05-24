using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MotoCross: VehiculoCarrera
    {
        private short cilindrada;

        #region Propiedades
        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                if (value > 0)
                {
                    this.cilindrada = value;
                }
            }
        }
        #endregion

        #region Constructores
        public MotoCross(): base()
        {

        }
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(MotoCross a, MotoCross b)
        {
            return (VehiculoCarrera)a == (VehiculoCarrera)b && a.Cilindrada == b.Cilindrada;
        }

        public static bool operator !=(MotoCross a, MotoCross b)
        {
            return !(a == b);
        }
        #endregion

        #region Metodos
        public override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.Append(base.MostrarDatos());
            datos.AppendLine($"Cilindrada: {this.Cilindrada}");

            return datos.ToString();
        }
        public override bool Equals(object? obj)
        {
            return (obj is not null && obj is MotoCross && (MotoCross)obj == this);
        }
        #endregion
    }
}
