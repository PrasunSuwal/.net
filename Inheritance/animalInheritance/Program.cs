using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalInheritance
{
    public class Program
    {
        class Animal
        {
            string name, type, size;
            
            public void createAnimal()
            {
                Console.WriteLine("Enter the dog's name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the breed of dog");
                type = Console.ReadLine();
                Console.WriteLine("Enter the size of dog");
                size = Console.ReadLine();
            }
            public void displayAnimal()
            {
                Console.WriteLine("The name of dog" + name);
                Console.WriteLine("The type of dog is" + type);
                Console.WriteLine("The size of dog is " + size);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
