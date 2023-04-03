using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02_I03
{
    internal class Conversor
    {
        static public void ConvertirDecimalABinario(int numeroEntero, StringBuilder resultado)
        {
            if (numeroEntero != 0)
            {
                Conversor.ConvertirDecimalABinario(numeroEntero / 2, resultado);

                resultado.Append(numeroEntero % 2);
            }
        }
    }
}
