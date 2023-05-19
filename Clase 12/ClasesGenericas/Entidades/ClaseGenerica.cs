namespace Entidades
{
    public class ClaseGenerica<T> where T : Persona, new ()
    {
        public void ImprimirValor(T elemento) 
        {
            Console.WriteLine(elemento);
        }
    }
}