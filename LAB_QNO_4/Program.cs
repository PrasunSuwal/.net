using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_QNO_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the first number
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            // Prompt the user to enter the second number
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Display numbers before swapping
            Console.WriteLine($"\nBefore swapping: num1 = {num1}, num2 = {num2}");

            // Swap the numbers
            int temp = num1;
            num1 = num2;
            num2 = temp;

            // Display numbers after swapping
            Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
        }
    }
}
