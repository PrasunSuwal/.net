using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_No_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter a number to print its multiplication table: ");
            int number = int.Parse(Console.ReadLine());

            // Print the multiplication table
            Console.WriteLine($"\nMultiplication Table for {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
