using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diglets
{
    internal class Program
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a + " , " + b+" = "+(a+b)); 
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a + " , " + b + " = " + (a - b));
        }
        public delegate void AddNum(int a, int b);  
        public delegate void SubNum(int a, int b);  

        static void Main(string[] args)
        {
            Program p =new Program();
            //p.Add(1,2); 
            //p.Sub(5,2); 
            //p.Sub(5,2); 
            AddNum a = new AddNum(p.Add);   
            SubNum b = new SubNum(p.Sub);
            a(20, 30);
            b(30, 10);

        }
    }
}
