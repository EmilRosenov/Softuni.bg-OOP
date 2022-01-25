using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string type = Console.ReadLine();

                if (type=="Beast!")
                {
                    break;
                }

                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                string gender = input[2];

                if (type=="Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    animals.Add(cat);
                }
                else if (type == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    animals.Add(dog);
                }
                else if (type == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    animals.Add(frog);
                }
                else if (type == "Tomcat")
                {
                    Tomcat tomCat = new Tomcat(name, age);
                    animals.Add(tomCat);
                }
                else if (type == "Kittens")
                {
                    Kitten kitty = new Kitten(name, age);
                    animals.Add(kitty);
                }

            }

            foreach (Animal animal in animals)
            {
                if (animal.Age<0 || animal.Name=="")
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    Console.WriteLine(animal.GetType().Name);
                    Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");
                    Console.WriteLine($"{animal.ProduceSound()}");
                }
                
            }
        }
    }
}
