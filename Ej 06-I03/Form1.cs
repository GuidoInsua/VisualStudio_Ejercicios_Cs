using System.Text;
using System.Web;

namespace Ej_06_I03
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> _contadorPalabras;
        private List<string> _palabras;

        public Form1()
        {
            InitializeComponent();

            _contadorPalabras = new Dictionary<string, int>();
            _palabras = new List<string>();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            _contadorPalabras.Clear();
            _palabras.Clear();

            ContarPalabras(rtbx_palabras.Text);

            _contadorPalabras = _contadorPalabras.OrderByDescending(i => i.Value).ToDictionary(i => i.Key, i => i.Value);

            MessageBox.Show(MostarTop3());
        }

        private void ContarPalabras(string texto)
        {
            char[] separador = new char[] { ' ', ',', '.', ':', '\t' };
            _palabras.AddRange(texto.Split(separador, StringSplitOptions.RemoveEmptyEntries));

            foreach (string s in _palabras)
            {
                if (_contadorPalabras.ContainsKey(s))
                {
                    _contadorPalabras[s]++;
                }
                else
                {
                    _contadorPalabras.Add(s, 1);
                }
            }
        }

        private string MostarTop3()
        {
            StringBuilder myString = new StringBuilder();

            int i = 0;

            if (_contadorPalabras.Count == 0)
            {
                myString.AppendLine("Vacio");
            }

            foreach (KeyValuePair<string, int> elemento in _contadorPalabras)
            {
                i++;
                myString.AppendLine($"{elemento.Key}   {elemento.Value}");

                if (i >= 3)
                {
                    break;
                }
            }

            return myString.ToString();
        }

        private void rtbx_palabras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}