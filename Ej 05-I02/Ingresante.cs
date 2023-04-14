using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_05_I02
{
    internal class Ingresante
    {
        private string[] _cursos = new string[3];
        private string _direccion;
        private int _edad;
        private string _genero;
        private string _nombre;
        private string _pais;

        public Ingresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais)
        {
            _cursos = cursos;
            _direccion = direccion;
            _edad = edad;
            _genero = genero;
            _nombre = nombre;
            _pais = pais;
        }

        public string Mostrar()
        {
            StringBuilder myString = new StringBuilder();

            myString.AppendLine($"Nombre: {_nombre}");
            myString.AppendLine($"Direccion: {_direccion}");
            myString.AppendLine($"Edad: {_edad}");
            myString.AppendLine($"Genero: {_genero}");
            myString.AppendLine($"Pais: {_pais}");
            myString.AppendLine("Cursos: ");

            for (int i = 0; i < _cursos.Length; i++)
            {
                if (_cursos[i] != null)
                {
                    myString.Append($"{_cursos[i]} / ");
                }
            }

            return myString.ToString();
        }
    }
}
