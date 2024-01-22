//Guido Insua 

namespace Ej_01_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I01 - Máximo, mínimo y promedio";

            int numero;
            int maximo = 0;
            int minimo = 0;
            bool rtaParse;

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.Write("Ingrese un numero: ");

                    rtaParse = int.TryParse(Console.ReadLine(), out numero);

                    if ( !rtaParse )
                    {
                        Console.WriteLine("ERROR");
                    }

                } while (!rtaParse);

                if(i == 0)
                {
                    maximo = numero;
                    minimo = numero;
                }

                if (numero > maximo)
                {
                    maximo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;    
                }

                promedio = promedio + numero;
            }

            promedio = promedio / 5;

            Console.WriteLine("El numero maximo es = {0}", maximo );
            Console.WriteLine("El numero minimo es = {0}", minimo);
            Console.WriteLine("El promedio es = {0}", promedio);
        }
    }
}