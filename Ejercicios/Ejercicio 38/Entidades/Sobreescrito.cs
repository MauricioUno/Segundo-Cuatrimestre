using System;

namespace Entidades
{
    public class Sobreescrito
    {
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