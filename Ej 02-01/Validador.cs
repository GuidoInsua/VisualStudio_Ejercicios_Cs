using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02_I01
{
    internal class Validador
    {
        /// <summary>
        /// Valida que el numero este entre min y max
        /// </summary>
        /// <param name="valor">Numero a validar</param>
        /// <param name="min">Valor minimo posible</param>
        /// <param name="max">Valor maximo posible</param>
        /// <returns>Retorna Verdadero si esta dentro de min y max</returns>
        static public bool Validar(int valor, int min, int max)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            return false;
        }

    }
}
