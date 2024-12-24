using System;

// Base class
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayPersonDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

// Derived class
public class Employee : Person
{
    public decimal Salary { get; set; }
    public string Position { get; set; }

    public Employee(string name, int age, decimal salary, string position) : base(name, age)
    {
        Salary = salary;
        Position = position;
    }

    public void DisplayEmployeeDetails()
    {
        // Display base class details
        DisplayPersonDetails();

        // Display derived class details
        Console.WriteLine($"Salary: {Salary:C}");
        Console.WriteLine($"Position: {Position}");
    }
}

// Example usage
class Program
{
    static void Main(string[] args)
    {
        // Create an employee object
        Employee employee = new Employee("Jane Smith", 30, 75000, "Software Engineer");

        // Display employee details
        employee.DisplayEmployeeDetails();
    }
}
