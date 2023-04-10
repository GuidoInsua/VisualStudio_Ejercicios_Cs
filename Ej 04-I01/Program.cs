//Guido Insua

namespace Ej_04_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I01 - Sumador";
            
            Sumador unSumador = new Sumador();

            Console.WriteLine(unSumador.Sumar(3, 5));
            Console.WriteLine(unSumador.Sumar("Hola", ", como estas?"));

            int cantidad = (int)unSumador;

            Console.WriteLine(cantidad);

            Sumador otroSumador = new Sumador(2);

            if (unSumador | otroSumador)
            {
                Console.WriteLine("Iguales");
            }
            else
            {
                Console.WriteLine("Distintos");
            }

            Console.WriteLine(unSumador + otroSumador);

        }
    }
}