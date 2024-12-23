using System;

class Student
{
    // Properties for student details
    public string Name { get; set; }
    public int Age { get; set; }
    public string Faculty { get; set; }
    public int Semester { get; set; }
    public string Grade { get; set; }

    // Constructor to initialize the properties
    public Student(string name, int age, string faculty, int semester, string grade)
    {
        Name = name;
        Age = age;
        Faculty = faculty;
        Semester = semester;
        Grade = grade;
    }

    // Method to display student information
    public void DisplayInformation()
    {
        Console.WriteLine("Student Information:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Faculty: {Faculty}");
        Console.WriteLine($"Semester: {Semester}");
        Console.WriteLine($"Grade: {Grade}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get student details from the user
        Console.WriteLine("Enter the student's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the student's age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the student's faculty:");
        string faculty = Console.ReadLine();

        Console.WriteLine("Enter the student's semester:");
        int semester = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the student's grade:");
        string grade = Console.ReadLine();

        // Create a Student instance
        Student student = new Student(name, age, faculty, semester, grade);

        // Display the student information
        student.DisplayInformation();
    }
}