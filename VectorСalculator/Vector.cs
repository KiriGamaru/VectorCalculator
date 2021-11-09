using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VectorСalculator
{
    public class Vector
    {
        private double x;
        private double y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // выводит координаты вектора в виде (5 4, 1 0, 3 3 и т.д.)
        public string Verbose()
        {
            return String.Format("{0} ; {1}", this.x, this.y);
        }

        //сложение двух векторов
        public static Vector Addition (Vector a, Vector b)
        {
            var c = new Vector(0, 0);
            c.x = a.x + b.x;
            c.y = a.y + b.y;
            return c;
        }

        //вычитание двух векторов
        public static Vector Subtraction (Vector a, Vector b)
        {
            var c = new Vector(0, 0);
            c.x = a.x - b.x;
            c.y = a.y - b.y;
            return c;
        }

        //вычисление скалярного произведения двух векторов
        public static double Skal (Vector a, Vector b)
        {
            return a.x * b.x + a.y * b.y;
        }

        //вычисление длины вектора
        public static double Length (Vector a)
        {
            return Math.Sqrt(Math.Pow(a.x, 2) + Math.Pow(a.y, 2));
        }

        //вычисление векторного произведения двух векторов
        public static double CrossProduct(Vector a, Vector b)
        {
            var Cos = Vector.Skal(a, b) / (Vector.Length(a) * Vector.Length(b));
            var Sin = Math.Sqrt(1 - Math.Pow(Cos, 2));
            return (float)Vector.Length(a) * Vector.Length(b) * Sin; ;
        }

    }
}
