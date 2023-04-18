using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_08_C01
{
    internal class Jugador : Persona
    {
        private int _partidosJugados;
        private int _totalGoles;

        public int PartidosJugados { get => _partidosJugados; }
        public int TotalGoles { get => _totalGoles; }
        public float PromedioGoles
        {
            get
            {
                if (PartidosJugados == 0)
                {
                    return 0;
                }

                return (float)TotalGoles / PartidosJugados;
            }
        }

        public Jugador(int dni, string nombre) : base(dni, nombre) { }

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados) : this(dni, nombre)
        {
            _totalGoles = totalGoles;
            _partidosJugados = partidosJugados;
        }

        public override string ToString()
        {
            StringBuilder myString = new StringBuilder();

            myString.AppendLine($"Nombre: {Nombre}");
            myString.AppendLine($"Dni: {Dni}");
            myString.AppendLine($"Partidos Jugados: {PartidosJugados}");
            myString.AppendLine($"Promedio goles: {PromedioGoles:F2}");
            myString.AppendLine($"Goles totales: {TotalGoles}");

            return myString.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.Dni == j2.Dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
