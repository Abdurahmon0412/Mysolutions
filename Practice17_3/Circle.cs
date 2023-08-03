using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Circle sealed modelidan foydalaning -Shape modelidan inheritance olgan bo’lsin

//unda quyidagi konstruktorlar bo’lsin

//- Circle ( radius )

//unda quyidagi methodlarni override qiling

//- CalculateArea
namespace Practice17_3
{
    public sealed class Circle: Shape
    {

        public double Radius { get; set; }
        public Circle(double radius) 
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return  Math.PI * ( Radius * Radius);
        }
    }
}
