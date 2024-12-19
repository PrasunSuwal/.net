using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        class Animal
        {
            string name, color;

            public void setData()
            {
                Console.WriteLine("Enter the name of animal");
                name = Console.ReadLine();
                Console.WriteLine("Enter the color of the animal");
                color = Console.ReadLine();
            }
            public void getData()
            {
                Console.WriteLine("The name of the animal is" + name);
                Console.WriteLine("The color of the animal is " + color);
            }
        }
        class Dog : Animal {
            public string sound;
            public void setDogData()
            {
                Console.WriteLine("Enter the sound that dog made");
                sound = Console.ReadLine();
            }
            public void getDogData()
            {
                Console.WriteLine("The dog makes" + sound);
            }
        }
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.setData();
            dog.setDogData();
            dog.getData();
            dog.getDogData();

        }
    }
}
