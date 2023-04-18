using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_08_C01
{
    internal class Persona
    {
        private long _dni;
        private string _nombre;

        public long Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public Persona(string nombre) 
        {
            Nombre = nombre;
        }

        public Persona(long dni, string nombre) : this(nombre)
        {
            Dni = dni;
        }

        public override string ToString()
        {
            StringBuilder myString = new StringBuilder();

            myString.AppendLine($"Dni: {Dni}");
            myString.AppendLine($"Nombre: {Nombre}");

            return myString.ToString();
        }
    }
}
