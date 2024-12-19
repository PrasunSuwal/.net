using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    internal class Program
    {
        public abstract class Animal
        {
            public abstract void eat();
            public abstract void makeSound();
        }
        public class Dog:Animal
        {
            public override void  eat()
            {
                Console.WriteLine("the dog eat meat");
            }
            public override void makeSound() {
                Console.WriteLine("the dog bark like bhow bhow");
            }
                       
        }
        public class Cat : Animal
        {
            public override void eat()
            {
                Console.WriteLine("the cat eat milk");
            }
            public override void makeSound()
            {
                Console.WriteLine("the cat makes sound like meow meow");
            }

        }
        static void Main(string[] args)
        {
            //Animal a  = new Animal();  
            Dog.dog = new Dog();
            dog.eat();
            Dog.makeSound();

            Cat.cat = new Cat();
            Cat.eat();


        }
    }
}
