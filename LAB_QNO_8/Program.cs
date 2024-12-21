using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_QNO_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an array of integers
            int[] numbers = { 5, 12, 20, 8, 15, 30 };

            // Display the array
            Console.WriteLine("Array: " + string.Join(", ", numbers));

            // Prompt the user to enter a number to check
            Console.Write("Enter a number to check: ");
            int target = int.Parse(Console.ReadLine());

            // Check only the first 4 elements of the array
            int lengthToCheck = Math.Min(numbers.Length, 4); // Handle cases where the array has less than 4 elements
            bool isPresent = false;
            for (int i = 0; i < lengthToCheck; i++)
            {
                if (numbers[i] == target)
                {
                    isPresent = true;
                    break;
                }
            }

            // Display the result
            if (isPresent)
            {
                Console.WriteLine($"The number {target} is present in the first 4 elements of the array.");
            }
            else
            {
                Console.WriteLine($"The number {target} is not present in the first 4 elements of the array.");
            }
        }
    }
}
