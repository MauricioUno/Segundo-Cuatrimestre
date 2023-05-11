using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private EPuesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        private PuestoAtencion() 
        {

        }

        public PuestoAtencion(EPuesto puesto): this()
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get
            {
                PuestoAtencion.numeroActual += 1;
                return PuestoAtencion.numeroActual;
            }
        }

        public bool Atender(Cliente cliente) 
        {
            Random tiempo = new Random();
            Thread.Sleep(tiempo.Next(1000, 5000));
            return true;
        }
    }

}
