using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public class Program
    {
        //method overloading
        public double add(double x, double y)
        {
            return x + y;
        }
        public class program2 : Program {
            public double add(double x, double y)
            {
                return x + y;
            }
        }
        
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.add(1.1, 2.1));
            //p.add(2, 3);
        }
    }
}
