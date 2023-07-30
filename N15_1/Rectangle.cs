using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_1
{
    public class Rectangle
    {
        public Rectangle(Point a, Point b, Point c, Point d)
        {
            if (!IsValid(a, b, c, d))
                throw new ArgumentException("Buningizdan turtburchak bulmaydi");
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        public double Perimetr { get => AB + BC + CD + AD; }
        public double AB { get => GetLenght(A, B); }
        public double BC { get => GetLenght(A, B); }
        public double CD { get => GetLenght(A, B); }
        public double AD { get => GetLenght(A, B); }
        public double AC { get => GetLenght(A, C); }


        public double Area
        {
            get
            {
                var partA = new Triangle(AB, BC, AC);
                var partB = new Triangle(AD, CD, AC);
                return partA.Area + partB.Area;
            }
        }


        private double GetLenght(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        private bool IsValid(Point a, Point b, Point c, Point d)
        {
            var pointX = new double[] { a.X, b.X, c.X, d.X };
            var pointY = new double[] { a.Y, b.Y, c.Y, d.Y };

            foreach (var pointA in pointX)
            {
                var count = 0;
                foreach (var pointB in pointX)
                {
                    if (pointA == pointB)
                    {
                        count++;
                    }
                }
                if (count > 2)
                    return false;
            }


            foreach (var pointA in pointY)
            {
                var count = 0;
                foreach (var pointB in pointY)
                {
                    if (pointA == pointB)
                    {
                        count++;
                    }
                }
                if (count > 2) return false;
            }
            return true;
        }
    }


}
