using System.Text;

namespace Entidades
{
    public class VehiculoCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        #region Propiedades
        public short CantidadCombustible
        {
            get 
            {
                return this.cantidadCombustible;
            }
            set 
            {
                if (value >= 0) 
                {
                    this.cantidadCombustible = value;
                }
            }
        }
        public bool EnCompetencia 
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public string Escuderia 
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        public short Numero 
        {
            get
            {
                return this.numero;
            }
            set
            {
                if (value > 0) 
                {
                    this.numero = value;
                }
            }
        }
        public short VueltasRestantes 
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                if (value >= 0) 
                {
                    this.vueltasRestantes = value;
                }
            }
        }
        #endregion

        #region Constructores
        public VehiculoCarrera() 
        {

        }
        public VehiculoCarrera(short numero, string escuderia)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(VehiculoCarrera autoA, VehiculoCarrera autoB)
        {
            return (autoA.numero == autoB.numero) && (autoA.escuderia == autoB.escuderia);
        }

        public static bool operator !=(VehiculoCarrera autoA, VehiculoCarrera autoB)
        {
            return !(autoA == autoB);
        }
        #endregion

        #region Metodos
        public virtual string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Escuderia: {this.escuderia}");
            datos.AppendLine($"Numero: {this.numero}");
            datos.AppendLine($"Cant. Combustible: {this.cantidadCombustible}");

            return datos.ToString();
        }

        public override bool Equals(object? obj)
        {
            return (obj is not null && obj is VehiculoCarrera && (VehiculoCarrera)obj == this);
        }
        #endregion

    }
}