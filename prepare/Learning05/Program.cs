using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(5, "Red");
        Rectangle rect1 = new Rectangle(6, 10, "Blue");
        Circle circ1 = new Circle(2, "White");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rect1);
        shapes.Add(circ1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color= {shape.GetColor()}");
            Console.WriteLine($"Area= {shape.GetArea()}");
        }
    }
}