//Guido Insua

namespace Ej_06_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I01 - Números locos";

            List<int> lista = new List<int>();  
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(-100, 100));
            }

            Console.WriteLine("\n------Lista original------\n");

            foreach (int i in lista)
            {
                Console.Write($" {i} /");
            }

            Console.WriteLine("\n\n------Lista positivos decreciente------\n");

            lista.Sort((numeros1, numeros2) =>
            {
                return numeros2.CompareTo(numeros1);
            });

            foreach (int i in lista)
            {
                if (i > 0)
                {
                    Console.Write($" {i} /");
                }
            }

            Console.WriteLine("\n\n------Lista negativos creciente------\n");

            lista.Reverse();

            foreach (int i in lista)
            {
                if (i < 0)
                {
                    Console.Write($" {i} /");
                }
            }

            Console.WriteLine("\n");
        }
    }
}