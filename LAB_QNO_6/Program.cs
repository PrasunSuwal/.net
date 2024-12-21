using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_QNO_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a positive number
            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());

            // Validate that the input is positive
            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
                return;
            }

            // Check if the number is a multiple of 3 or 7
            if (number % 3 == 0 || number % 7 == 0)
            {
                Console.WriteLine($"{number} is a multiple of 3 or 7.");
            }
            else
            {
                Console.WriteLine($"{number} is not a multiple of 3 or 7.");
            }
        }
    }
}
