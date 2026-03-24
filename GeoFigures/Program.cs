using System;

namespace GeoFigures
{
    class Program
    {
        static void Main()
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(3.5);

            Triangle triangle1 = new Triangle(6, 8);
            Triangle triangle2 = new Triangle(3, 4);

            Rectangle rectangle1 = new Rectangle(4, 7);
            Rectangle rectangle2 = new Rectangle(10, 2);

            Console.WriteLine("CIRCLE:");
            Console.WriteLine("circle1 area = " + circle1.GetArea());
            Console.WriteLine("circle1 perimeter = " + circle1.GetPerimeter());
            Console.WriteLine("circle2 area = " + circle2.GetArea());
            Console.WriteLine("circle2 perimeter = " + circle2.GetPerimeter());

            Console.WriteLine();

            Console.WriteLine("TRIANGLE:");
            Console.WriteLine("triangle1 area = " + triangle1.GetArea());
            Console.WriteLine("triangle1 perimeter = " + triangle1.GetPerimeter());
            Console.WriteLine("triangle2 area = " + triangle2.GetArea());
            Console.WriteLine("triangle2 perimeter = " + triangle2.GetPerimeter());

            Console.WriteLine();

            Console.WriteLine("RECTANGLE:");
            Console.WriteLine("rectangle1 area = " + rectangle1.GetArea());
            Console.WriteLine("rectangle1 perimeter = " + rectangle1.GetPerimeter());
            Console.WriteLine("rectangle2 area = " + rectangle2.GetArea());
            Console.WriteLine("rectangle2 perimeter = " + rectangle2.GetPerimeter());
        }
    }
}