using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            // Prompt user to enter the second number
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Compute the result
            int result = (num1 == num2) ? 3 * (num1 + num2) : num1 + num2;

            // Display the result
            Console.WriteLine("The result is: " + result);
        }
    }
}
