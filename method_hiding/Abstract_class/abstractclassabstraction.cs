using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public abstract class abstractclassabstraction
    {
        public string bookname;
        public int bookprice;
        public string bookauthor;
        public void setData()
        {
            Console.WriteLine("Enter the name of book");
            bookname = Console.ReadLine();
            Console.WriteLine("Enter the price of book");
            bookprice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the author of the book");
            bookauthor = Console.ReadLine();
        }
        public abstract void getData();
        
    }
    public class abstractclassAccess:abstractclassabstraction
    {
        public override void getData()
        {
            Console.WriteLine("The book name is " + bookname);
            Console.WriteLine("The book price is " + bookprice);
            Console.WriteLine("The book author is" + bookauthor);
        }
    }
}
