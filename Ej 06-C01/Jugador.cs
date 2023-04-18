using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_06_C01
{
    internal class Jugador
    {
        private int _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioGoles;
        private int _totalGoles;

        public float PromedioGoles { get => _promedioGoles; }

        private Jugador() 
        {
            _partidosJugados = 0;
            _promedioGoles = 0;
            _totalGoles = 0;
        }

        public Jugador(int dni, string nombre) : this() 
        {
            _dni = dni;
            _nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int partidosJugados) : this(dni, nombre)
        {
            _totalGoles = totalGoles;
            _partidosJugados = partidosJugados;
        }

        public float GetPromedioGoles()
        {
            if (_partidosJugados != 0)
            {
                _promedioGoles = (float)_totalGoles / _partidosJugados;
            }

            return _promedioGoles;
        }

        public override string ToString()
        {
            StringBuilder myString = new StringBuilder();

            myString.AppendLine($"Nombre: {_nombre}");
            myString.AppendLine($"Dni: {_dni}");
            myString.AppendLine($"Partidos Jugados: {_partidosJugados}");
            myString.AppendLine($"Promedio goles: {GetPromedioGoles():F2}");
            myString.AppendLine($"Goles totales: {_totalGoles}");

            return myString.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1._dni == j2._dni);
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1==j2);
        }
    }
}
