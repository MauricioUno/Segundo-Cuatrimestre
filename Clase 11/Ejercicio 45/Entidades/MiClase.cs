using System.Linq.Expressions;

namespace Entidades
{
    public class MiClase
    {

        public MiClase()
        {
            try
            {
                MiClase.LanzarExcepcion();
            }
            catch (Exception ex)
            {
                throw new FormatException("PLUS: Constructor de instancia MiClase; FormatException", ex);
            }
            
        }

        public MiClase(int id) 
        {
            try
            {
                new MiClase();
            }
            catch(Exception ex) 
            {
                throw new UnaExcepcion("Constructor de instancia MiClase ID; UnaExcepcion", ex);
            }
        }
        
        public static void LanzarExcepcion()
        {
            throw new DivideByZeroException("Metodo Estatico MiClase; DivideByZeroException");
        }
    }

    
}