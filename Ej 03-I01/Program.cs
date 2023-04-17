//Guido Insua 

namespace Ej_03_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I01 - Creo que necesito un préstamo";

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