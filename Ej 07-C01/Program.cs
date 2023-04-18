//Guido Insua

namespace Ej_07_C01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio C01 - Jugadores encapsulados";

            Equipo equipo = new Equipo(3, "utn");
            Jugador primerJugador = new Jugador(123, "pepe", 5, 20);
            Jugador segundoJugador = new Jugador(485, "julian", 3, 5);
            Jugador tercerJugador = new Jugador(123, "marcos", 7, 3);
            Jugador cuartoJugador = new Jugador(789, "luis", 3, 5);

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