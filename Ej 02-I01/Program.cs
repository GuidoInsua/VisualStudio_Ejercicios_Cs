//Guido Insua

namespace Ej_02_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I01 - Validador de rangos";

            int numero;
            int maximo = 0;
            int minimo = 0;
            int suma = 0;
            double promedio;
            bool primero = true;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    if(!primero)
                    {
                        Console.WriteLine("ERROR, Ingrese un numero entre -100 y 100");
                    }

                    numero = Pedir.Entero();

                    primero = false;

                } while (!Validador.Validar(numero, -100, 100));

                primero = true;

                if(numero > maximo || i == 0)
                {
                    maximo = numero; 
                }

                if(numero < minimo || i == 0)
                {
                    minimo = numero;
                }

                suma = numero + suma;
            }

            promedio = suma / 10.0;

            Console.WriteLine($"Numero maximo = {maximo}");
            Console.WriteLine($"Numero minimo = {minimo}");
            Console.WriteLine($"Promedio = {promedio}");
        }
    }
}