using System.Text;

namespace Entidades
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia) 
        {
            this.cantidadCombustible = 0;
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public string MostrarDatos() 
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine($"Escuderia: {this.escuderia}");
            datos.AppendLine($"Numero: {this.numero}");
            datos.AppendLine($"Cant. Combustible: {this.cantidadCombustible}");

            return datos.ToString();
        }

        public static bool operator ==(AutoF1 autoA, AutoF1 autoB) 
        {
            return (autoA.numero == autoB.numero) && (autoA.escuderia == autoB.escuderia);
        }

        public static bool operator !=(AutoF1 autoA, AutoF1 autoB)
        {
            return !(autoA == autoB);
        }

        public override bool Equals(object? obj)
        {
            return (obj is not null && obj is AutoF1 && (AutoF1)obj == this);
        }

        public short GetCantidadCombustible() 
        {
            return this.cantidadCombustible;
        }

        public void SetCantidadCombustible(short cantidad)
        {
            this.cantidadCombustible = cantidad;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public void SetVueltasRestantes(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetEnCompetencia(bool compitiendo)
        {
            this.enCompetencia = compitiendo;
        }
    }
}