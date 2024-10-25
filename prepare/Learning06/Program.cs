using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("black", 10);
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("White", 3, 5);
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("Red", 5);
        Console.WriteLine(circle.GetArea());

        List <Shape> shapeList = new List<Shape>();
        shapeList.Add(circle);
        shapeList.Add(rectangle);
        shapeList.Add(square);  

        foreach(Shape shape in shapeList)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}