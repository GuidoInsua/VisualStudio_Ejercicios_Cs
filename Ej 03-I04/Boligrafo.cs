using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03_I04
{
    internal class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color) 
        {
            this.color = color;
            SetTinta(tinta);
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        public short GetTinta()
        {
            return tinta;
        }

        private void SetTinta(short tinta) 
        {
            if(tinta + this.tinta > 0 && tinta + this.tinta <= 100) 
            {
                this.tinta += tinta;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short pintar = (short)(GetTinta() - gasto);

            StringBuilder myString = new StringBuilder();

            if(pintar < 0)
            {
                gasto += pintar;
            }

            SetTinta((short)(gasto * -1));

            for(int i=0; i<gasto; i++) 
            {
                myString.Append('*');
            }

            dibujo = myString.ToString();

            return true;
        }

        public void MostrarPintura(string pintura)
        {
            Console.ForegroundColor = GetColor();
            Console.WriteLine(pintura);
            Console.ResetColor();
        }

    }
}
