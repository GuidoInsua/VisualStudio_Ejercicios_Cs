//Guido Insua 

using System;
using System.Collections;

namespace Ej_06_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I02 - Números locos II";

            List<int> lista = new List<int>();
            Stack<int> pila = new Stack<int>();
            Queue<int> cola = new Queue<int>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(-100, 100));
                pila.Push(random.Next(-100, 100));
                cola.Enqueue(random.Next(-100, 100));
            }

            Console.WriteLine("\n------Lista original------\n");

            foreach(int i in lista)
            {
                Console.Write($" {i} /");
            }

            Console.WriteLine("\n\n------Lista positivos decreciente------\n");

            lista.Sort((numeros1, numeros2) =>
            {
                return numeros2.CompareTo(numeros1);
            });

            foreach (int i in lista)
            {
                if (i > 0)
                {
                    Console.Write($" {i} /");
                }
            }

            Console.WriteLine("\n\n------Lista negativos creciente------\n");

            lista.Reverse();

            foreach (int i in lista)
            {
                if (i < 0)
                {
                    Console.Write($" {i} /");
                }
            }

            Console.WriteLine("\n\n------Pila original------\n");

            foreach (int i in pila)
            {
                Console.Write($" {i} /");
            }

            Console.WriteLine("\n\n------Pila positivos decreciente------\n");
            
            pila = new Stack<int>(pila.OrderBy(q => q));

            foreach (int i in pila)
            {
                if (i > 0)
                {
                    Console.Write($" {i} /");
                }
            }

            Console.WriteLine("\n\n------Pila negativos creciente------\n");

            pila = new Stack<int>(pila.OrderByDescending(q => q));

            foreach (int i in pila)
            {
                if (i < 0)
                {
                    Console.Write($" {i} /");
                }
            }

            Console.WriteLine("\n\n------Cola original------\n");

            foreach (int i in cola)
            {
                Console.Write($" {i} /");
            }

            Console.WriteLine("\n\n------Cola positivos decreciente------\n");

            cola = new Queue<int>(cola.OrderByDescending(q => q));

            foreach (int i in cola)
            {
                if (i > 0)
                {
                    Console.Write($" {i} /");
                }
            }

            Console.WriteLine("\n\n------Cola negativos creciente------\n");

            cola = new Queue<int>(cola.Reverse());

            foreach (int i in cola)
            {
                if (i < 0)
                {
                    Console.Write($" {i} /");
                }
            }

            Console.WriteLine("\n");
        }
    }
}