using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CentralitaException: Exception
    {
        public CentralitaException(string mensaje): base(mensaje) { }

        public CentralitaException(string mensaje,  Exception innerException): base(mensaje, innerException) { }
    }
}
