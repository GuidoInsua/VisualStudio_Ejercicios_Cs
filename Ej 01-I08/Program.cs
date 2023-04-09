//Guido Insua

namespace Ej_01_I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dibujando un triángulo rectángulo";

            int numero;

            Console.Write("Ingrese numero: ");

            int.TryParse(Console.ReadLine(), out numero);

            for (int i=0;i < numero; i++)
            {
                for (int j=0;j < i*2; j++)
                {
                    Console.Write("*");
                }
                Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}