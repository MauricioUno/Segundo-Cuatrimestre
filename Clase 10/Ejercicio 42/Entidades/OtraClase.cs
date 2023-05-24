using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        public void InstanciarMiClase() 
        {
            try 
            {
                new MiClase(123);
            }
            catch(Exception ex) 
            {
                throw new MiExcepcion("Metodo OtraClase; MiExcepcion", ex);
            }
        }
    }
}
