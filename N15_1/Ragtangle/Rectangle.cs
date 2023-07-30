using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N15_1.Ragtangle
{
    public class Rectangle
    {
        public Rectangle(Point a, Point b, Point c,Point d)
        {
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
        public double AB { get => GetLenght(A,B); }
        public double BC { get => GetLenght(A, B); }
        public double CD { get => GetLenght(A, B); }
        public double AD { get => GetLenght(A, B); }


        private double GetLenght(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow((a.Y - b.Y),2));
        }
    }

    
}
