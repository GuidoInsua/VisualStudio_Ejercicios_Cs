//Guido Insua 

using Billetes;

namespace Ej_04_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I02 - Cotizador";

            Peso pesos = new Peso(100);
            Dolar dolares = new Dolar(100);
            Euro euros = new Euro(100);

            Console.WriteLine($"Tengo {pesos.Cantidad} pesos, que son {((Dolar)pesos).Cantidad:F3} de dolares y {((Euro)pesos).Cantidad:F3} de euros");
            Console.WriteLine($"Tengo {dolares.Cantidad} dolares, que son {((Peso)dolares).Cantidad:F3} de pesos y {((Euro)dolares).Cantidad:F3} de euros");
            Console.WriteLine($"Tengo {euros.Cantidad} euros, que son {((Dolar)euros).Cantidad:F3} de dolares y {((Peso)euros).Cantidad:F3} de pesos");
        }
    }
}