//Guido Insua 

namespace Ej_01_I04_Bis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I04 BIS - Un número perfecto";

            double numero = 1;
            int cantidad = 1;
            double resultado = 0;

            do
            {
                numero++;

                if(EsPrimo((Math.Pow(2, numero) - 1)))
                {
                    resultado = (Math.Pow(2, numero - 1)) * (Math.Pow(2, numero) - 1);
                    Console.WriteLine($"Nº{cantidad} --> {resultado} ");
                    cantidad++;
                }
            } while (cantidad <= 8);
        }

        public static bool EsPrimo(double numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}