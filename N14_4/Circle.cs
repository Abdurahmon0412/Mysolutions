using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N14_4
{
    public class Circle : Shape
    {
        public Circle()
        {
            
        }
        public override int CalculateArea(int r,int ikki = 2)
        {
            return (int)(Math.PI * Math.Pow(r, 2));

        } 
    }
}
