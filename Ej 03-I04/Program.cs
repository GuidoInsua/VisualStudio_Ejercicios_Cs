//Guido Insua

namespace Ej_03_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I04 - Invento argentino";

            string pintura;

            Boligrafo primerBoligrafo = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo segundoBoligrafo = new Boligrafo(50, ConsoleColor.Red);

            segundoBoligrafo.Recargar();

            for (short i = 0; i <= 5; i++)
            {
                primerBoligrafo.Pintar(i, out pintura);
                primerBoligrafo.MostrarPintura(pintura);
            }

            for (short i = 5; i > 0; i--)
            {
                segundoBoligrafo.Pintar(i, out pintura);
                segundoBoligrafo.MostrarPintura(pintura);
            }
        }
    }
}