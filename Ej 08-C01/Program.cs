//Guido Insua

namespace Ej_08_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio C01 - Herencia deportiva";

            Equipo equipo = new Equipo(3, "utn");
            Jugador primerJugador = new Jugador(123, "Pedro", 5, 20);
            Jugador segundoJugador = new Jugador(485, "Julian", 3, 5);
            Jugador tercerJugador = new Jugador(123, "Marcos", 7, 3);
            Jugador cuartoJugador = new Jugador(789, "Luis", 3, 5);

            DateTime fecha = new DateTime(1995, 12, 08);

            DirectorTecnico director1 = new DirectorTecnico("Juan",fecha);
            DirectorTecnico director2 = new DirectorTecnico("Pepe", 32, fecha);

            if(director1 == director2) Console.WriteLine(director1);
            else Console.WriteLine($"---Dos DT distintos---\n\n{director1} \n{director2}---------------\n");

            if (equipo + primerJugador) Console.WriteLine(primerJugador);
            else Console.WriteLine($"--No se agrego--\n{primerJugador}---------------\n");

            if (equipo + segundoJugador) Console.WriteLine(segundoJugador);
            else Console.WriteLine($"--No se agrego--\n{segundoJugador}---------------\n");

            if (equipo + tercerJugador) Console.WriteLine(tercerJugador);
            else Console.WriteLine($"--No se agrego--\n{tercerJugador}---------------\n");

            if (equipo + cuartoJugador) Console.WriteLine(cuartoJugador);
            else Console.WriteLine($"--No se agrego--\n{cuartoJugador}---------------\n"); 
        }
    }
}