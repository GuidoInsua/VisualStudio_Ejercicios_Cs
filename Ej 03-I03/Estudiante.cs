using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03_I03
{
    internal class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void SetNotaPrimerParcial(int notaPrimerPacial)
        {
            this.notaPrimerParcial = notaPrimerPacial;
        }

        public void SetNotaSegundoParcial(int notaSegundoPacial)
        {
            this.notaSegundoParcial = notaSegundoPacial;
        }

        private float CalcularPromedio()
        {
            return (float)((notaPrimerParcial + notaSegundoParcial) / 2.0);
        }

        public double CalcularNotaFinal()
        {
            if(notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 10) + random.NextDouble();
            }

            return -1;
        }

        public override string ToString()
        {
            double notaFinal = CalcularNotaFinal();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nota primer parcila: {notaPrimerParcial}");
            sb.AppendLine($"Nota segundo parcial: {notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");

            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota final: {notaFinal:N1}");
                return sb.ToString();
            }

            sb.AppendLine("Alumno desaprobado");

            return sb.ToString();
        }
    }
}
