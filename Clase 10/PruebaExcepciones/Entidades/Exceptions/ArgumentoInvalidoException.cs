namespace Entidades.Exceptions
{
    public class ArgumentoInvalidoException: Exception
    {
        public ArgumentoInvalidoException(string mensaje): base(mensaje)
        {

        }

        public ArgumentoInvalidoException(string mensaje, Exception innerException) : base(mensaje, innerException)
        {

        }
    }
}