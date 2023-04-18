using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_08_C01
{
    internal class DirectorTecnico : Persona
    {
        private DateTime _fechaNacimiento;

        private DirectorTecnico(string nombre) : base(nombre) 
        {
            _fechaNacimiento = new DateTime();
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre) 
        {
            _fechaNacimiento = fechaNacimiento;
        }

        public DirectorTecnico(string nombre, int dni, DateTime fechaNacimiento) : base(dni, nombre)
        {
            _fechaNacimiento = fechaNacimiento;
        }

        public override string ToString()
        {
            StringBuilder myString = new StringBuilder();

            myString.AppendLine($"Nombre: {Nombre}");
            myString.AppendLine($"Dni: {Dni}");
            myString.AppendLine($"Fecha de nacimiento: {_fechaNacimiento :d}");

            return myString.ToString();
        }

        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return (dt1.Nombre == dt2.Nombre && dt1._fechaNacimiento == dt2._fechaNacimiento);
        }

        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
