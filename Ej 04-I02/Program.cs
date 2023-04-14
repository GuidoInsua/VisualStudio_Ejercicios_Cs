//Guido Insua

using Billetes;

namespace Ej_04_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I02 - Cotizador";

            Euro billeteEuro = new Euro(1);
            Peso billetePeso = (Peso)billeteEuro;
            Dolar billeteDolar = 100;

            Console.WriteLine(billetePeso.Cantidad);
            billetePeso = (Peso)billeteDolar;
            Console.WriteLine($"Cantidad de Dolares convertidos a Peso {billetePeso.Cantidad}");

        }
    }
}