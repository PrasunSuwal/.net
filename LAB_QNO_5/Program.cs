using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_QNO_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // Print the message
            Console.WriteLine($"You look older than {age}.");
        }
    }
}
