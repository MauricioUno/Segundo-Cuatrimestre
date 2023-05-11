namespace Entidades
{
    public class Libro
    {
        private List<string> paginas = new List<string>();

        public string this[int indice] 
        {
            get 
            {
                if (indice >= 0 && indice <= paginas.Count - 1)
                {
                    return paginas[indice];
                }
                else 
                {
                    return $"Pagina {indice} no existe";
                }
            }

            set 
            {
                if (indice >= 0 && indice <= paginas.Count - 1)
                {
                    paginas[indice] = value;
                }
                else 
                {
                    paginas.Add(value);
                }
            }
        }
    }

   
}