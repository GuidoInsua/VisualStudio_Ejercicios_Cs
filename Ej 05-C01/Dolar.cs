using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_05_C01
{
    internal class Dolar
    {
        private double _cantidad;
        public double Cantidad { get => _cantidad; set => _cantidad = value; }

        private static double _cotzRespectoDolar;
        public static double CotzRespectoDolar { get => _cotzRespectoDolar; }

        static Dolar()
        {
            Dolar._cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            _cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar._cotzRespectoDolar = cotizacion;
        }

        //implicita

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        //Explicita

        public static explicit operator Euro(Dolar d)
        {
            return new Euro((d.Cantidad * Euro.CotzRespectoDolar));
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso((d.Cantidad * Peso.CotzRespectoDolar));
        }

        //Sobrecarga

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.Cantidad == d2.Cantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.Cantidad == ((Dolar)e).Cantidad);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.Cantidad == ((Dolar)p).Cantidad);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar((d.Cantidad - ((Dolar)e).Cantidad));
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar((d.Cantidad - ((Dolar)p).Cantidad));
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar((d.Cantidad + ((Dolar)e).Cantidad));
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar((d.Cantidad + ((Dolar)p).Cantidad));
        }
    }
}
