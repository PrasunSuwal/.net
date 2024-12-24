using System;

// Base class
public class Shape
{
    // Virtual methods for area and perimeter
    public virtual double GetArea()
    {
        return 0;
    }

    public virtual double GetPerimeter()
    {
        return 0;
    }

    public void DisplayShapeDetails()
    {
        Console.WriteLine($"Area: {GetArea()}");
        Console.WriteLine($"Perimeter: {GetPerimeter()}");
    }
}

// Derived class
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Override methods to calculate area and perimeter
    public override double GetArea()
    {
        return Width * Height;
    }

    public override double GetPerimeter()
    {
        return 2 * (Width + Height);
    }

    public void DisplayRectangleDetails()
    {
        Console.WriteLine($"Width: {Width}");
        Console.WriteLine($"Height: {Height}");
        base.DisplayShapeDetails();
    }
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        // Create a rectangle object
        Rectangle rectangle = new Rectangle(5, 10);

        // Display rectangle details
        rectangle.DisplayRectangleDetails();
    }
}
