using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03_I05
{
    internal class Pedir
    {
        static public int Entero(string mensaje, string mensajeError)
        {
            bool flag;
            int numero;

            do
            {
                Console.Write(mensaje);

                flag = int.TryParse(Console.ReadLine(), out numero);

                if (!flag)
                {
                    Console.WriteLine(mensajeError);
                }

            } while (!flag);

            return numero;
        }
    }
}
