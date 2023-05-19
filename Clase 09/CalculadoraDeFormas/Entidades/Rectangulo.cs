using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rectangulo: Figura
    {
        private double xBase;
        private double yAltura;

        public Rectangulo(double xBase, double yAltura) 
        {
            this.xBase = xBase;
            this.yAltura = yAltura;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo...";
        }
        public override double CalcularSuperficie() 
        {
            return this.xBase * this.yAltura;
        }
        public override double CalcularPerimetro() 
        {
            return (this.xBase + this.yAltura)*2;
        }
    }
}
