using System;

// Define a delegate
public delegate void DisplayMessage(string message);

// Define a sealed class
public sealed class SealedClass
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the sealed class
        SealedClass sealedClass = new SealedClass();

        // Use a delegate to reference the ShowMessage method
        DisplayMessage display = sealedClass.ShowMessage;

        // Use a lambda expression to create a message
        string message = "Hello, this is a message from a sealed class using a delegate and a lambda expression!";

        // Call the delegate with the lambda expression
        display(message);
    }
}
