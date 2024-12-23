using System;

class Circle
{
    // Property for radius
    public double Radius { get; set; }

    // Constructor to initialize radius
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Method to calculate area
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    // Method to calculate circumference
    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    // Display the circle details
    public void DisplayDetails()
    {
        Console.WriteLine("Circle Details:");
        Console.WriteLine($"Radius: {Radius}");
        Console.WriteLine($"Area: {CalculateArea():F2}");
        Console.WriteLine($"Circumference: {CalculateCircumference():F2}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get radius from the user
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        // Create a Circle instance
        Circle circle = new Circle(radius);

        // Display circle details
        circle.DisplayDetails();
    }
}