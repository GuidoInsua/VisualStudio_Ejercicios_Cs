using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02_I04
{
    internal class Pedir
    {
        static public bool Entero(out int numero,string mensajeError)
        {
            Console.Write("Ingrese un numero: ");

            if(!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine(mensajeError);
                return false;
            }

            return true;
        }

        static public bool Doble(out double numero, string mensajeError)
        {
            Console.Write("Ingrese un numero: ");

            if (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine(mensajeError);
                return false;
            }

            return true;
        }

        static public bool Caracter(out char caracter, string mensajeError)
        {
            Console.Write("Ingrese un caracter: ");

            if (!char.TryParse(Console.ReadLine(), out caracter))
            {
                Console.WriteLine(mensajeError);
                return false;
            }

            return true;
        }
    }
}
