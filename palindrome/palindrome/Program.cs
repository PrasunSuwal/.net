using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    using System;

    class PalindromeCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            // Check if the input is a valid number
            if (int.TryParse(input, out int number))
            {
                bool isPalindrome = IsPalindrome(number);
                if (isPalindrome)
                {
                    Console.WriteLine($"{number} is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a palindrome.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        static bool IsPalindrome(int num)
        {
            int original = num;
            int reversed = 0;

            // Reverse the number
            while (num > 0)
            {
                int remainder = num % 10;
                reversed = (reversed * 10) + remainder;
                num /= 10;
            }

            // Check if original and reversed numbers are the same
            return original == reversed;
        }
    }
}
