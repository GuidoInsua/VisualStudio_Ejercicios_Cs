using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_04_I01
{
    internal class Sumador
    {
        private int _cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            _cantidadSumas = cantidadSumas;
        }

        public Sumador():this(0) { }

        public long Sumar(long a, long b) 
        {
            _cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b) 
        {
            _cantidadSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador v)
        {
            return v._cantidadSumas;
        }

        public static bool operator |(Sumador v1, Sumador v2)
        {
            if ((int)v1 == (int)v2)
            {
                return true;
            }
            return false;
        }

        public static long operator +(Sumador v1, Sumador v2)
        {
            return (int)v1 + (int)v2;
        }
    }
}
