using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace Ej_03_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta unaCuenta = new Cuenta("Guido Insua",3412);

            Console.WriteLine(unaCuenta);

            Console.WriteLine("*Ingreso 1000 pesos\n");

            unaCuenta.Ingresar(1000);

            Console.WriteLine(unaCuenta);

            Console.WriteLine("*Retiro 6000 pesos\n");

            unaCuenta.Retirar(6000);

            Console.WriteLine(unaCuenta);   
        }
    }
}