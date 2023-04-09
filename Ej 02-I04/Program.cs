//Guido Insua

namespace Ej_02_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I04 - La calculadora";

            double primerNumero;
            double segundoNumero;
            char operdaor;
            double resultado;
            bool bandera;
            char continuar;

            do
            {
                do
                {
                } while (!Pedir.Doble(out primerNumero, "ERROR, Numero no valido"));

                do
                {
                } while (!Pedir.Doble(out segundoNumero, "ERROR, Numero no valido"));

                do
                {
                    bandera = true;
                    if (!Pedir.Caracter(out operdaor, "ERROR") ||
                        (operdaor != '+' && operdaor != '-' && operdaor != '*' && operdaor != '/'))
                    {
                        bandera = false;
                        Console.WriteLine("ERROR, Ingrese (+, -, *, /)");
                    }
                } while (!bandera);

                if (Calculadora.Calcular(primerNumero, segundoNumero, operdaor, out resultado))
                {
                    Console.WriteLine($"Resultado: {resultado}");
                }

                Console.WriteLine("desea continuar ? (S/N)");

                Pedir.Caracter(out continuar, "ERROR");

                bandera = false;
                if(continuar == 's' ||  continuar == 'S')
                {
                    bandera = true;
                }
                
            } while (bandera);
        }
    }
}