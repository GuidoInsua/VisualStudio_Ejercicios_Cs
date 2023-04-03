using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02_I02
{
    internal class Pedir
    {
        static public int Entero()
        {
            int numero;
            bool primer = true;

            do
            {
                if (!primer)
                {
                    Console.WriteLine("ERROR");
                }

                primer = false;

                Console.Write("Ingrese un numero: ");

            } while (!int.TryParse(Console.ReadLine(), out numero));

            return numero;
        }

    }
}
