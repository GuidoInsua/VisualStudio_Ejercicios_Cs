using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03_A01
{
    internal class Conductor
    {
        private String nombre;
        private int[] kilometrosPorDia = new int[7];

        public Conductor(string nombre, int[] kilometrosPorDia) 
        {
            this.nombre = nombre;

            for (int i = 0; i < 7; i++) 
            {
                this.kilometrosPorDia[i] = kilometrosPorDia[i];
            }
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int[] GetKilometrosPorDia() 
        {
            return kilometrosPorDia;
        }

        public int ObtenerKilometrosUnDia(int dia)
        {
            return kilometrosPorDia[dia];
        }

        public int ObtenerKilometrosTotalSemana()
        {
            int suma = 0;

            for (int i = 0;i < 7;i++) 
            {
                suma += ObtenerKilometrosUnDia(i);
            }

            return suma;
        }
    }
}
