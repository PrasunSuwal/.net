using System;

class Rectangle
{
    // Properties for length and width
    public double Length { get; set; }
    public double Width { get; set; }

    // Constructor to initialize length and width
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return Length * Width;
    }

    // Method to calculate perimeter
    public double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }

    // Display the rectangle details
    public void DisplayDetails()
    {
        Console.WriteLine($"Rectangle Details:");
        Console.WriteLine($"Length: {Length}, Width: {Width}");
        Console.WriteLine($"Area: {CalculateArea()}");
        Console.WriteLine($"Perimeter: {CalculatePerimeter()}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Rectangle instance
        Console.WriteLine("Enter the length of the rectangle:");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the width of the rectangle:");
        double width = Convert.ToDouble(Console.ReadLine());

        Rectangle rect = new Rectangle(length, width);

        // Display rectangle details
        rect.DisplayDetails();
    }
}