//Guido Insua

namespace Ej_03_A01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio A01 - Vienen con sistema de auto-navegación";

            string nombre = " ";
            int[] kilometrosPorDia = new int[7];
            const int cantidadConductores = 3;
            int posicion;
            int kilometros;

            Conductor[] conductores = new Conductor[cantidadConductores];

            for (int i = 0; i < cantidadConductores; i++)
            {
                Console.Write($" Ingrese el nombre del conductor {i + 1}: ");
                nombre = Console.ReadLine();

                for (int j = 0; j < 7; j++)
                {
                    kilometrosPorDia[j] = Pedir.Entero($"Ingrese la cantidad de kilometros en el dia {j + 1}: ", "ERROR, Ingrese un numero");
                }

                conductores[i] = new Conductor(nombre, kilometrosPorDia);

                Console.WriteLine("");
            }

            posicion = ConductorConMasKilometrosSemanal(conductores, out kilometros);
            Console.WriteLine($"El conductor con mas kilometros es {conductores[posicion].GetNombre()} con {kilometros} Km");

            posicion = ConductorConMasKilometrosDia(conductores, out kilometros, 2);
            Console.WriteLine($"El conductor con mas kilometros en el tercer dia es {conductores[posicion].GetNombre()} con {kilometros} Km");

            posicion = ConductorConMasKilometrosDia(conductores, out kilometros, 4);
            Console.WriteLine($"El conductor con mas kilometros en el quinto dia es {conductores[posicion].GetNombre()} con {kilometros} Km");
        }

        static int ConductorConMasKilometrosDia(Conductor[] conductores, out int maxKilometros, int dia)
        {
            int cantidad;
            int conductor = 0;

            maxKilometros = 0;

            for (int i = 0; i < conductores.Length; i++)
            {
                cantidad = conductores[i].ObtenerKilometrosUnDia(dia);

                if (cantidad > maxKilometros)
                {
                    maxKilometros = cantidad;
                    conductor = i;
                }
            }

            return conductor;
        }

        static int ConductorConMasKilometrosSemanal(Conductor[] conductores, out int maxKilometros)
        {
            int cantidad;
            int conductor = 0;

            maxKilometros = 0;

            for (int i = 0; i < conductores.Length; i++)
            {
                cantidad = conductores[i].ObtenerKilometrosTotalSemana();

                if (cantidad > maxKilometros)
                {
                    maxKilometros = cantidad;
                    conductor = i;
                }
            }

            return conductor;
        }
    }
}