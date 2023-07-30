using N15_1;
using System.Drawing;
using Point = N15_1.Point;
using Rectangle = N15_1.Rectangle;

try
{

    Triangle triangle = new Triangle(3, 4, 3);
    Console.WriteLine($"Yuz: = {triangle.Area} \nPerimetr = {triangle.Perimeter}");
}
catch(ArgumentException exp)
{
    Console.WriteLine(exp.Message );
}
var o = new Point(0, 0);
try
{
    var rectangle = new Rectangle(new Point(0, 2), new Point(0, 3), new Point(0, 4), new Point(2, 0));
    Console.WriteLine(rectangle.Area);
}
catch( ArgumentException exp )
{
    Console.WriteLine(exp.Message );
}
