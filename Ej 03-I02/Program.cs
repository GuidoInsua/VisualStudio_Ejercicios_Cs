//Guido Insua

namespace Ej_03_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I02 - ¿Vos cuántas primaveras tenés?";

            Persona primerPersona = new Persona("Guido", 2000, 9, 11, 42653888);
            Persona segundaPersona = new Persona("Pedro", 2010, 7, 12, 32133123);
            Persona terceraPersona = new Persona("Maria", 2002, 3, 8, 31234855);

            Console.WriteLine(primerPersona);
            Console.WriteLine(segundaPersona);
            Console.WriteLine(terceraPersona);

            Console.WriteLine(primerPersona.EsMayorDeEdad());
            Console.WriteLine(segundaPersona.EsMayorDeEdad());
            Console.WriteLine(terceraPersona.EsMayorDeEdad());
        }
    }
}