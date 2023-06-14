using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 10.5);
        Rectangle rectangle = new Rectangle("blue", 4.5, 11.6);
        Circle circle = new Circle("yellow", 5.5);

        List <Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes) {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}