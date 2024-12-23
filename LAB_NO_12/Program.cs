using System;

class Vehicle
{
    // Properties for brand, model, and year
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    // Constructor to initialize the properties
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // Method to display the vehicle details
    public void DisplayDetails()
    {
        Console.WriteLine("Vehicle Details:");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
    }

    // Method to clear the properties
    public void ClearDetails()
    {
        Brand = null;
        Model = null;
        Year = 0;
        Console.WriteLine("Vehicle details cleared.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Vehicle instance
        Console.WriteLine("Enter the vehicle brand:");
        string brand = Console.ReadLine();

        Console.WriteLine("Enter the vehicle model:");
        string model = Console.ReadLine();

        Console.WriteLine("Enter the vehicle year:");
        int year = Convert.ToInt32(Console.ReadLine());

        Vehicle vehicle = new Vehicle(brand, model, year);

        // Display the details
        vehicle.DisplayDetails();

        Console.WriteLine();

        // Clear the details
        vehicle.ClearDetails();
    }
}