using System.Text;

namespace Ej_02_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I03 - Conversor binario";

            int numero;
            StringBuilder resultado = new StringBuilder();

            numero = Pedir.Entero();

            Conversor.ConvertirDecimalABinario(numero, resultado);

            Console.WriteLine(resultado);   
        }
    }
}