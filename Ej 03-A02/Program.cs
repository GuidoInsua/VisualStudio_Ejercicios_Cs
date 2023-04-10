//Guido Insua

namespace Ej_03_A02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio A02 - La veterinaria";

            Cliente cliente1 = new Cliente("Caballito", "Guido", "Insua", "2342344");
            Mascota mascota1 = new Mascota("Perro","Negro",2015,11,20);
            cliente1.SetMascota(mascota1);

            Cliente cliente2 = new Cliente("Leluar 543", "Juan", "Perez", "453534");
            Mascota mascota2 = new Mascota("Gato", "Perla", 2008, 9, 3);
            mascota2.SetVacuna("Tripe Felina");
            mascota2.SetVacuna("Tripe Felina");
            mascota2.SetVacuna("Tripe Felina");
            cliente2.SetMascota(mascota2);

            Cliente cliente3 = new Cliente("San martin 434", "Miguel", "Bolivar", "123434");
            Mascota mascota3 = new Mascota("Gato", "Blanquita", 2010, 10, 13);
            Mascota mascota4 = new Mascota("Perro", "Max", 2021, 4, 11);
            mascota4.SetVacuna("Rabia");
            mascota4.SetVacuna("Pulgas");
            cliente3.SetMascota(mascota3);
            cliente3.SetMascota(mascota4);

            cliente1.MostrarCliente();
            Console.WriteLine("\n-----------------\n");
            cliente2.MostrarCliente();
            Console.WriteLine("\n-----------------\n");
            cliente3.MostrarCliente();
        }
    }
}