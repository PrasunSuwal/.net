using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @delegate
{
    internal class Program
    {
        public void getDetails(int age, string address, string name)
        {
            Console.WriteLine(age + " " + name + " " + address);
        }
        public delegate void userDetails(int age, string address, string name);
        static void Main(string[] args)
        {
            Program p = new Program();
            userDetails u = new userDetails(p.getDetails);
            u(21, "KTM", "Prasun");
            u(21, "KTM", "Prasun");
            u(21, "KTM", "Prasun");
            u(21, "KTM", "Prasun");
            u(21, "KTM", "Prasun");
            u(21, "KTM", "Prasun");
            u(21, "KTM", "Prasun");
        }
    }
}
