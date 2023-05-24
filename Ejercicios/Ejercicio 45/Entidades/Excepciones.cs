using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UnaExcepcion: Exception
    {
        public UnaExcepcion(string mensaje) : base(mensaje)
        {
            
        }

        public UnaExcepcion(string mensaje, Exception excepcion) : base(mensaje, excepcion)
        {

        }
    }

    public class MiExcepcion : Exception 
    {
        public MiExcepcion(string mensaje) : base(mensaje)
        {

        }

        public MiExcepcion(string mensaje, Exception excepcion) : base(mensaje, excepcion)
        {

        }
    }
}
