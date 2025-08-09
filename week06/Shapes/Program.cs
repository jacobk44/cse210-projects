using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 5);
        shapes.Add(square);
        Console.WriteLine();


        Circle circle = new Circle("Blue", 9);
        shapes.Add(circle);
        Console.WriteLine();


        Rectangle rectangle = new Rectangle("Pink", 9, 5);
        shapes.Add(rectangle);
        Console.WriteLine();


        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();


            Console.WriteLine($"The {color} shape has an area of {area:F2}");
        }


    }
}