using System.Linq;
using System.Text.RegularExpressions;
namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        private MatchCollection palabras;
        private Dictionary<string, int> contadorPalabras;
        private List<KeyValuePair<string, int>> listaPalabras;

        public Form1()
        {
            
            InitializeComponent();
            this.contadorPalabras = new Dictionary<string, int>();
            this.listaPalabras = new List<KeyValuePair<string, int>>();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
    
            this.palabras = Regex.Matches(this.txtLienzo.Text.ToLower(), @"\b\w+\b");
            if (this.palabras.Count > 0)
            {
                foreach (Match palabra in palabras)
                {
                    if (!this.contadorPalabras.ContainsKey(palabra.Value))
                    {
                        this.contadorPalabras.Add(palabra.Value, 1);
                    }
                    else
                    {
                        this.contadorPalabras[palabra.Value] += 1;
                    }
                }
                this.listaPalabras = this.contadorPalabras.OrderByDescending(palabra => palabra.Value).Take(3).ToList();
                string topTres = string.Join("\n", this.listaPalabras.Select(p => $"{p.Key}: {p.Value}"));
                MessageBox.Show(topTres, "Palabras mas repetidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.contadorPalabras.Clear();
            }
            else 
            {
                MessageBox.Show("No se ingreso ninguna palabra", "Palabras mas repetidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
                


                
            

            
        }
    }
}