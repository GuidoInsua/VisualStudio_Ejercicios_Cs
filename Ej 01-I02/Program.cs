//Guido Insua 

namespace Ej_01_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I02 - Error al cubo";

            int numero;
            bool rtaParse;
            double cuadrado;
            double cubo;

            do
            {
                Console.Write("Ingrese un numero: ");

                rtaParse = int.TryParse(Console.ReadLine(), out numero);

                if (!rtaParse || numero <= 0)
                {
                    Console.WriteLine("ERROR");

                    rtaParse = false;
                }

            } while (!rtaParse);

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine($"cuadrado = {cuadrado}");
            Console.WriteLine($"cubo = {cubo}");
        } 
    }
}