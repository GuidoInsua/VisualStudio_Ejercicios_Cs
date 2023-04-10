using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03_A02
{
    internal class Cliente
    {
        private string _domicilio;
        private string _nombre;
        private string _apellido;
        private string _telefono;
        private Mascota[] _mascotas = new Mascota[4];

        public Cliente(string _domicilio, string _nombre, string _apellido, string _telefono)
        {
            this._domicilio = _domicilio;
            this._nombre = _nombre;
            this._apellido = _apellido;
            this._telefono = _telefono;
        }

        public void SetMascota(Mascota unaMascota)
        {
            for(int i=0; i <  _mascotas.Length; i++) 
            {
                if (_mascotas[i] == null)
                {
                    _mascotas[i] = unaMascota;
                    break;
                }
            }
        }
        
        public string GetDomicilo() 
        {
            return _domicilio;
        }

        public string GetNombre()
        {
            return _domicilio;
        }

        public string GetApellido()
        {
            return _domicilio;
        }

        public string GetTelefono()
        {
            return _domicilio;
        }

        public Mascota GetUnaMascota(int posicion)
        {
            return _mascotas[posicion];
        }

        public void MostrarCliente()
        {
            Console.WriteLine($"Domicilio: {_domicilio}");
            Console.WriteLine($"Nombre: {_nombre}");
            Console.WriteLine($"Apellido: {_apellido}");
            Console.WriteLine($"Telefono: {_telefono}");

            for(int i = 0; i < _mascotas.Length; i++) 
            {
                if (_mascotas[i] != null) 
                {
                    Console.WriteLine($"\nMascota: {i + 1}\n");
                    _mascotas[i].MostarMascota();
                }
            }
        }
    }
}
