//Guido Insua

namespace Ej_01_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I04 - Un número perfecto";

            int numero = 1;
            int divisor = 1;
            int suma = 0;
            int cantidad = 1;

            do
            {
                numero++;

                do
                {
                    if (numero % divisor == 0)
                    {
                        suma = suma + divisor;
                    }

                    divisor++;

                } while (divisor < numero);

                if (suma == numero)
                {
                    Console.WriteLine($"Nº{cantidad} --> {numero} ");

                    cantidad++;
                }

                divisor = 1;
                suma = 0;
            } while (cantidad <= 4);
        }
    }
}