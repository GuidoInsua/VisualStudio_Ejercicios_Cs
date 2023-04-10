using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_03_I05
{
    internal class Rectangulo
    {
        /*
         *    4 *----------* 3
         *      |          |
         *      |          |
         *      |          |
         *    1 *----------* 2
        */

        private float area = 0;
        private float perimetro = 0;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)        
        {
            Punto vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            Punto vertice4 = new Punto(vertice3.GetX(), vertice2.GetY());

            this.vertice1 = vertice1;
            this.vertice2 = vertice2;
            this.vertice3 = vertice3;
            this.vertice4 = vertice4;
        }

        public float GetArea()
        {
            if (area == 0)
            {
                float suelo = Math.Abs(vertice2.GetY()) - Math.Abs(vertice1.GetY());
                float altura = Math.Abs(vertice4.GetX()) - Math.Abs(vertice1.GetX());

                area = suelo * altura;
            }

            return area;
        }

        public float GetPerimetro()
        {
            if (perimetro == 0)
            {
                float suelo = Math.Abs(vertice2.GetY()) - Math.Abs(vertice1.GetY());
                float altura = Math.Abs(vertice4.GetX()) - Math.Abs(vertice1.GetX());

                perimetro = (suelo + altura) / 2;
            }

            return perimetro;
        }
    }
}
