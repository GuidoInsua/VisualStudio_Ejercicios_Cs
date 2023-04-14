using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Euro
    {
        private double _cantidad;
        public double Cantidad { get => _cantidad; }

        private static double _cotzRespectoDolar;
        public static double CotzRespectoDolar { get => _cotzRespectoDolar; }

        static Euro()
        {
            Euro._cotzRespectoDolar = 1 / 1.18;
        }

        public Euro(double cantidad)
        {
            _cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            Euro._cotzRespectoDolar = cotizacion;
        }

        //Implicita

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }

        //Explicita

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar((e.Cantidad / Euro.CotzRespectoDolar));
        }

        public static explicit operator Peso(Euro e)
        {
            return (Peso)((Dolar)e);
        }

        //Sobrecarga

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.Cantidad == e2.Cantidad);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (e.Cantidad == ((Euro)d).Cantidad);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return (e.Cantidad == ((Euro)p).Cantidad);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro((e.Cantidad - ((Euro)d).Cantidad));
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro((e.Cantidad - ((Euro)p).Cantidad));
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro((e.Cantidad + ((Euro)d).Cantidad));
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro((e.Cantidad + ((Euro)p).Cantidad));
        }
    }
}
