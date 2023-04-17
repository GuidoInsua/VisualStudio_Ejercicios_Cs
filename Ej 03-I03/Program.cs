//Guido Insua 

namespace Ej_03_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I03 - El ejemplo universal";

            Estudiante primerEstudiante = new Estudiante("Insua", "34553", "Guido");
            Estudiante segundoEstudiante = new Estudiante("Rodriguez", "31255", "Juan");
            Estudiante tercerEstudiante = new Estudiante("Gutierrez", "13452", "Marcos");

            Console.WriteLine("Primer Alumno");
            primerEstudiante.SetNotaPrimerParcial(Pedir.Entero("Ingrese la nota del primer parcial: ","ERROR, Ingrese un numero entre 1 y 10"));
            primerEstudiante.SetNotaSegundoParcial(Pedir.Entero("Ingrese la nota del segundo parcial: ", "ERROR, Ingrese un numero entre 1 y 10"));

            Console.WriteLine("\nSegundo Alumno");
            segundoEstudiante.SetNotaPrimerParcial(Pedir.Entero("Ingrese la nota del primer parcial: ", "ERROR, Ingrese un numero entre 1 y 10"));
            segundoEstudiante.SetNotaSegundoParcial(Pedir.Entero("Ingrese la nota del segundo parcial: ", "ERROR, Ingrese un numero entre 1 y 10"));

            Console.WriteLine("\nTercer Alumno");
            tercerEstudiante.SetNotaPrimerParcial(Pedir.Entero("Ingrese la nota del primer parcial: ", "ERROR, Ingrese un numero entre 1 y 10"));
            tercerEstudiante.SetNotaSegundoParcial(Pedir.Entero("Ingrese la nota del segundo parcial: ", "ERROR, Ingrese un numero entre 1 y 10"));

            Console.WriteLine($"\n{primerEstudiante}");
            Console.WriteLine($"\n{segundoEstudiante}");
            Console.WriteLine($"\n{tercerEstudiante}");

        }
    }
}