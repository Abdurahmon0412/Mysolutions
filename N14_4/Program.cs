using N14_4;
using System.Drawing;
namespace N14_4
{
    class Program
    {
        static void Main()
        {
            Shape circle = new Circle();
            Console.WriteLine( circle.CalculateArea(12,15));

            Shape rectangle = new Rectengle();
            Console.WriteLine(rectangle.CalculateArea(12,65));

            var triangle = new Tringle();
            Console.WriteLine( triangle.CalculateArea(35,56));
        }
    }
}