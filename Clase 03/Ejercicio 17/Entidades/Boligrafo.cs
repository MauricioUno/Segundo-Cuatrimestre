using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;


        public Boligrafo(ConsoleColor color, short tinta) 
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor() 
        {
            return this.color;
        }

        public short GetTinta() 
        {
            return this.tinta;
        }

        private void SetTinta(short tinta) 
        {
            this.tinta = (short)(this.tinta + tinta);
            if (this.tinta > Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = Boligrafo.cantidadTintaMaxima;
            }
            else if (this.tinta < 0) 
            {
                this.tinta = 0;
            }
            
        }

        public void Recargar() 
        {
            this.SetTinta(Boligrafo.cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo) 
        {
            if (this.tinta > 0)
            {
                short tintaGastada = Math.Min(gasto, this.tinta);
                this.SetTinta((short)-gasto);
                dibujo = "".PadRight(tintaGastada, '*');
                return true;
            }
            else 
            {
                dibujo = "";
                return false;
            }
        }
    }
}
