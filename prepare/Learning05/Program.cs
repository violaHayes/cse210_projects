using System;

class Program
{
    static void Main(string[] args)
{
    List<Shape> shapes = new List<Shape>();

    shapes.Add(new Square("Blue", 5));
    shapes.Add(new Rectangle("Red", 4, 6));
    shapes.Add(new Circle("Green", 3));

    foreach (Shape s in shapes)
    {
        Console.WriteLine("Color: " + s.GetColor());
        Console.WriteLine("Area: " + s.GetArea());
        Console.WriteLine();
    }
}
}