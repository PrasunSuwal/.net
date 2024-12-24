using System;

public interface IShape
{
    double Area();
    double Perimeter();
}

public class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double Area()
    {
        return Length * Width;
    }

    public double Perimeter()
    {
        return 2 * (Length + Width);
    }
}

public class Square : IShape
{
    public double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }

    public double Area()
    {
        return Side * Side;
    }

    public double Perimeter()
    {
        return 4 * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape rectangle = new Rectangle(5.0, 3.0);
        Console.WriteLine($"Rectangle Area: {rectangle.Area()}");
        Console.WriteLine($"Rectangle Perimeter: {rectangle.Perimeter()}");

        IShape square = new Square(4.0);
        Console.WriteLine($"Square Area: {square.Area()}");
        Console.WriteLine($"Square Perimeter: {square.Perimeter()}");
    }
}
