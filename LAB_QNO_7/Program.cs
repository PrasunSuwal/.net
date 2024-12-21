using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_QNO_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an array of integers
            int[] numbers = { 10, 20, 30, 40, 50 };

            // Display the array
            Console.WriteLine("Array: " + string.Join(", ", numbers));

            // Prompt the user to enter a number to check
            Console.Write("Enter a number to check: ");
            int target = int.Parse(Console.ReadLine());

            // Check if the number is present in the array
            bool isPresent = Array.Exists(numbers, element => element == target);

            // Display the result
            if (isPresent)
            {
                Console.WriteLine($"The number {target} is present in the array.");
            }
            else
            {
                Console.WriteLine($"The number {target} is not present in the array.");
            }
        }
    }
}
