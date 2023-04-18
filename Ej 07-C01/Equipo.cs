using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_07_C01
{
    internal class Equipo
    {
        private short _cantidadDeJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        private Equipo()
        {
            _jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre) : this()
        {
            _cantidadDeJugadores = cantidadDeJugadores;
            _nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {

            if (e._jugadores.Count < e._cantidadDeJugadores)
            {
                foreach (Jugador item in e._jugadores)
                {
                    if (item == j) return false;
                }

                e._jugadores.Add(j);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
