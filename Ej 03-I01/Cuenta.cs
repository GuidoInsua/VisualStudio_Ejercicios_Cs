using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03_I01
{
    internal class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular ()
        {
            return titular;
        }

        public double GetCantidad()
        {
            return cantidad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Titular: {titular}");
            sb.AppendLine($"Saldo: ${cantidad}");

            return sb.ToString();
        }

        public void Ingresar (double cantidad)
        {
            if(cantidad > 0)
            {
               this.cantidad += cantidad;
            }
        }

        public void Retirar (double cantidad)
        {
            if(cantidad > 0) 
            {
                this.cantidad -= cantidad;
            }
        }

    }
}
