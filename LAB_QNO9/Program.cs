using System;

// Base class Animal
class Animal
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Size { get; set; }

    public void CreateAnimal(string name, string type, string size)
    {
        Name = name;
        Type = type;
        Size = size;
    }

    public void DisplayAnimal()
    {
        Console.WriteLine($"Name: {Name}, Type: {Type}, Size: {Size}");
    }
}

// Subclass Cat inheriting from Animal
class Cat : Animal
{
    public void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}

// Subclass Dog inheriting from Animal
class Dog : Animal
{
    public void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating and displaying a Cat
        Cat myCat = new Cat();
        myCat.CreateAnimal("Whiskers", "Cat", "Small");
        Console.WriteLine("Cat Details:");
        myCat.DisplayAnimal();
        myCat.MakeSound();

        Console.WriteLine();

        // Creating and displaying a Dog
        Dog myDog = new Dog();
        myDog.CreateAnimal("Buddy", "Dog", "Medium");
        Console.WriteLine("Dog Details:");
        myDog.DisplayAnimal();
        myDog.MakeSound();
    }
}
