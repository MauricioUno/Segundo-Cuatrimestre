namespace Entidades
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public abstract string MiPropiedad
        {
            get;
        }
        protected Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public abstract string MiMetodo();
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Sobreescrito;
        }
        public override int GetHashCode()
        {
            return 1142510187;
        }
    }
}