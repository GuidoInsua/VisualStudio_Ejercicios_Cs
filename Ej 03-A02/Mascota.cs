using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03_A02
{
    internal class Mascota
    {
        private string _especie;
        private string _nombre;
        private DateTime _fechaNacimiento;
        private string[] _vacunas = new string[10];

        public Mascota(string _especie, string _nombre, int anio, int mes, int dia)
        {
            this._especie = _especie;
            this._nombre = _nombre;
            SetFechaNaciemiento(anio, mes, dia);
        }

        private void SetFechaNaciemiento(int anio, int mes, int dia)
        {
            _fechaNacimiento = new DateTime(anio, mes, dia);
        }

        public void SetVacuna(string vacuna) 
        {
            for(int i=0; i <  _vacunas.Length; i++) 
            {
                if (_vacunas[i] == null)
                {
                    _vacunas[i] = vacuna;
                    break;
                }
            }
        }

        public string GetEspecie() 
        {
            return _especie;
        }

        public string GetNombre()
        {
            return _especie;
        }

        public DateTime GetFechaNacimiento()
        {
            return _fechaNacimiento;
        }

        public string GetUnaVacuna(int posicion)
        {
            return _vacunas[posicion];
        }

        public void MostarMascota()
        {
            bool bandera = false;

            Console.WriteLine($"Especie: {_especie}");
            Console.WriteLine($"Nombre: {_nombre}");
            Console.WriteLine($"Fecha de nacimiento: {_fechaNacimiento:d}");
            Console.Write($"Vacunas: ");

            for (int i = 0; i < _vacunas.Length; i++)
            {
                if (_vacunas[i] != null)
                {
                    Console.Write($"{_vacunas[i]} / ");
                    bandera = true;
                }
            }

            if (!bandera) 
            {
                Console.Write("No tiene");
            }

            Console.WriteLine("");
        }
    }
}
