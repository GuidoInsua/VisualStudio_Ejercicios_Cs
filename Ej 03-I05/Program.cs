//Guido Insua 

using System.Text;

namespace Ej_03_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I05 - Prueba de geometría";

            Console.WriteLine
                (
                "       4 *-------------* 3    \n" +
                "         |             |      \n" +
                "         |             |      \n" +
                "         |             |      \n" +
                "       1 *-------------* 2    \n"
                );

            int numero1;
            int numero2;
            int numero3;
            int numero4;
            bool bandera = false;

            numero1 = Pedir.Entero("Ingrese la posicion 'x' del vertice 1: ","ERROR, Ingrese un numero");
            numero2 = Pedir.Entero("Ingrese la posicion 'y' del vertice 1: ", "ERROR, Ingrese un numero");

            Punto punto1 = new Punto(numero1, numero2);

            Console.WriteLine("");

            do
            {
                if(bandera == true)
                {
                    Console.WriteLine("\nERROR, Ni la posicion 'x' o 'y' pueden ser igual o menor a las del vertice 1\n");
                }

                numero3 = Pedir.Entero("Ingrese la posicion 'x' del vertice 3: ", "ERROR, Ingrese un numero");
                numero4 = Pedir.Entero("Ingrese la posicion 'y' del vertice 3: ", "ERROR, Ingrese un numero");

                bandera = true;
            } while (numero3 <= numero1 || numero4 <= numero2);

            Punto punto2 = new Punto(numero3, numero4);

            Rectangulo unRectangulo = new Rectangulo(punto1,punto2);

            MostrarRectangulo(unRectangulo);
        }

        static void MostrarRectangulo(Rectangulo unRectangulo)
        {
            StringBuilder myString = new StringBuilder();

            myString.AppendLine($"Area: {unRectangulo.GetArea()}");
            myString.AppendLine($"Perimetro: {unRectangulo.GetPerimetro()}");

            Console.WriteLine(myString.ToString() );
        }
    }
}