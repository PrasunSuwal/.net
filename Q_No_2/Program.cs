using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_No_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                // Prompt user to enter the first number
                Console.Write("Enter the first number: ");
                double num1 = double.Parse(Console.ReadLine());

                // Prompt user to enter the second number
                Console.Write("Enter the second number: ");
                double num2 = double.Parse(Console.ReadLine());

                // Perform calculations
                double sum = num1 + num2;
                double difference = num1 - num2;
                double product = num1 * num2;
                double quotient = num2 != 0 ? num1 / num2 : double.NaN; // Handle division by zero

                // Display the results
                Console.WriteLine("Results:");
                Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
                Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
                Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

                if (num2 != 0)
                {
                    Console.WriteLine($"Division: {num1} / {num2} = {quotient}");
                }
                else
                {
                    Console.WriteLine("Division: Cannot divide by zero.");
                }
            
        }
    }
}
