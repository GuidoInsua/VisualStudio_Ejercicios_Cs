using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_02_I04
{
    internal class Calculadora
    {
        static public bool Calcular(double primerNumero, double segundoNumero, char operador, out double resultado)
        {
            bool operacion = true;
            resultado = 0;

            switch (operador)
            {
                case '+':

                    resultado = primerNumero + segundoNumero;
                    break;

                case '-':

                    resultado = primerNumero - segundoNumero;
                    break;

                case '*':

                    resultado = primerNumero * segundoNumero;
                    break;

                case '/':
                    
                    if (!Validar(segundoNumero))
                    {
                        Console.WriteLine("ERROR, No se puede dividir por 0");
                        operacion = false;
                        break;
                    }
                    resultado = primerNumero / segundoNumero;
                    break;
            }

            return operacion;
        }

        static bool Validar (double divisor)
        {
            if (divisor != 0) 
            {
                return true;
            }

            return false;
        }
    }
}
