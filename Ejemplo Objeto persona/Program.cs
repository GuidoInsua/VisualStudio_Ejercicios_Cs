namespace Ejemplo_Objeto_persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("guido", "insua", 4432);

            Console.WriteLine(personaUno);

            personaUno.nombre = "pepe";

            Console.WriteLine(personaUno);


        }
    }
}