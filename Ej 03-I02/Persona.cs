using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03_I02
{
    internal class Persona
    {
        private string nombre;
        private DateTime fecha;
        private int dni;


        public Persona(string nombre, int anio, int mes, int dia, int dni)
        {
            SetNombre(nombre);
            SetFecha(anio, mes, dia);
            SetDni(dni);
        }

        private void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        private void SetFecha(int anio, int mes, int dia)
        {
            fecha = new DateTime(anio, mes, dia);
        }

        private void SetDni(int dni)
        {
            this.dni = dni;
        }

        private string GetNombre()
        {
            return nombre;
        }

        private DateTime GetFecha()
        {
            return fecha;
        }

        private int GetDni()
        {
            return dni;
        }

        private double CalcularEdad ()
        {
            DateTime actual = DateTime.Now;

            TimeSpan diferencia = actual - fecha;

            double dias = diferencia.TotalDays;

            return Math.Floor(dias / 365);
        }

        public string EsMayorDeEdad ()
        {
            if (CalcularEdad() >= 18)
            {
                return "Es mayor de edad";
            }

            return "Es menor";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"nombre: {nombre}");
            sb.AppendLine($"fecha: {fecha}");
            sb.AppendLine($"dni: {dni}");
            sb.AppendLine($"edad: {CalcularEdad()}");

            return sb.ToString();
        }

    }
}
