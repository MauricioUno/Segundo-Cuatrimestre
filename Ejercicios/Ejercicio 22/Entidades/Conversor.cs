namespace Entidades
{
    public class Conversor
    {

        public static string DecimalABinario(int numero) 
        {
            bool negativo = numero < 0;

            numero = Math.Abs(numero);
            string resultados = "";
            string numeroBinario = "";
           
            while (numero > 1)
            {
                if (numero % 2 == 1)
                {
                    resultados += "1";
                }
                else
                {
                    resultados += "0";
                }
                numero /= 2;

            }
            resultados += numero.ToString();
              
            for (int i = resultados.Length - 1; i >= 0; i--) 
            {
            numeroBinario += resultados[i];
            }

            if (negativo) 
            {
                // AGREGAR COMPLEMENTO A2 JAAJAAJASDS
            }

            return numeroBinario;
        }

        public static int BinarioADecimal(string bin) 
        {
            int potencia;
            int num = 0;
            for (int i = 0; i < bin.Length; i++) 
            {
                if (bin[i] == '1') 
                {
                    potencia = 1;
                    for (int j = 0; j < (bin.Length - 1) - i; j++) 
                    {
                        potencia *= 2;
                    }
                    num += potencia;
                }
            }
            return num;

        }

    }
}