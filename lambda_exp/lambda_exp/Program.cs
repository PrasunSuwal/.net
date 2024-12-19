using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_exp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square=x=>x*x;
            Console.WriteLine("Square = " + square(3));
            Func<int, int,  int> Add = (x, y) =>x + y;
            Console.WriteLine("Addition " + Add(2, 3));
        }
    }
}
