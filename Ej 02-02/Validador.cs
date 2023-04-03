using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02_I02
{
    internal class Validador
    {

        static public bool ValidarRespuesta(char respuesta)
        {
            if (respuesta == 's' || respuesta == 'S')
            {
                return true;
            }

            return false;
        }
    }
}
