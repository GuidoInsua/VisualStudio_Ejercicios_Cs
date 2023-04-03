using System.Text;

namespace Ej_01_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool rtaParse;

            do
            {
                Console.Write("Ingrese un numero: ");

                rtaParse = int.TryParse(Console.ReadLine(), out numeroIngresado);

                if (!rtaParse || numeroIngresado <= 1)
                {
                    Console.WriteLine("ERROR");

                    rtaParse = false;
                }

            } while (!rtaParse);

            Console.WriteLine(ListarNumerosPrimos(numeroIngresado));
        }

        public static string ListarNumerosPrimos(int numeroTope)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 2; i <= numeroTope; i++) 
            {
                if (EsPrimo(i))
                {
                    sb.Append($"{i} ,");
                }
            }

            return sb.ToString();
        }

        public static bool EsPrimo(int numeroTope)
        {
            for (int i = 2; i < numeroTope; i++) 
            {
                if (numeroTope % i == 0) 
                {
                    return false;
                }
            }
            return true; 
        }
    }
}