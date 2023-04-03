
namespace Ej_02_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I02 - ¿Desea continuar?";

            int numero;
            char respuesta;
            int suma = 0;

            do
            {
                numero = Pedir.Entero();

                suma = suma + numero;

                Console.Write("¿Desea continuar? (S/N): ");

                char.TryParse(Console.ReadLine(), out respuesta);

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine($"La suma de los numeros es = {suma}");
        }
    }
}