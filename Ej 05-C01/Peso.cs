using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_05_C01
{
    internal class Peso
    {
        private double _cantidad;
        public double Cantidad { get => _cantidad; set => _cantidad = value; }

        private static double _cotzRespectoDolar;
        public static double CotzRespectoDolar 
        { get => _cotzRespectoDolar; set => _cotzRespectoDolar = value; }

        static Peso()
        {
            Peso._cotzRespectoDolar = 380;
        }

        public Peso(double cantidad)
        {
            _cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso._cotzRespectoDolar = cotizacion;
        }

        //Implicita

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }

        //Explicita

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((p.Cantidad / Peso.CotzRespectoDolar));
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }

        //Sobrecarga

        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.Cantidad == p2.Cantidad);
        }

        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return (p.Cantidad == ((Peso)d).Cantidad);
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return (p.Cantidad == ((Peso)e).Cantidad);
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso((p.Cantidad - ((Peso)d).Cantidad));
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso((p.Cantidad - ((Peso)e).Cantidad));
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso((p.Cantidad + ((Peso)d).Cantidad));
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso((p.Cantidad + ((Peso)e).Cantidad));
        }
    }
}
