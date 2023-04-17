//Guido Insua 

using System.Text;

namespace Ej_02_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I05 - Aprendete las tablas";

            int numero;
            StringBuilder myString = new StringBuilder();

            Console.Write("Ingrese numero: ");
            int.TryParse(Console.ReadLine(), out numero);

            myString.AppendLine($"Tabla de multiplicar del numero {numero}:");

            for (int i = 0; i < 10; i++)
            {
                myString.AppendLine($"{numero} x {i} = {numero * i}");
            }

            Console.WriteLine(myString);
        }
    }
}