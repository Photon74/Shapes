using System;
using Shapes;
using Shapes.Models;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5);
            Console.WriteLine(circle.GetArea());

            var triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle.IsRight());

            Console.ReadLine();
        }
    }
}
