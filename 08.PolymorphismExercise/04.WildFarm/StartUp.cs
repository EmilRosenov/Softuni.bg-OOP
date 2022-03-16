using System;
using System.Collections.Generic;using _04.WildFarm.Animal;
using _04.WildFarm.Food;

namespace _04.WildFarm.Animal
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Cat Sammy 1.1 Home Persian
            //Vegetable 4
            //End

            string[] input = Console.ReadLine().Split();
            List<IAnimal> animals = new List<IAnimal>();
            while (input[0] != "End")
            {
                string animalType = input[0];
                string animalName = input[1];
                double animalWeight = double.Parse(input[2]);

                
                string[] foodInput = Console.ReadLine().Split();
                string foodType = foodInput[0];
                int quantity = int.Parse(foodInput[1]);

                IAnimal animal = null;

                try
                {
                    if (animalType == nameof(Hen))
                    {
                        double wingSize = double.Parse(input[3]);
                        animal = new Hen(animalName, animalWeight, wingSize);
                        
                        //hen.Eat(IFood name);

                    }
                    else if (animalType == nameof(Owl))
                    {
                        double wingSize = double.Parse(input[3]);
                        animal= new Owl(animalName, animalWeight, wingSize);
                        
                        //owl.Eat();

                    }
                    else if (animalType == nameof(Mouse))
                    {
                        string livingRegion = input[3];
                        animal = new Mouse(animalName, animalWeight, livingRegion);
                        
                        //mouse.Eat(IFood name);

                    }
                    else if (animalType == nameof(Cat))
                    {
                        string livingRegion = input[3];
                        string breed = input[4];
                        animal = new Cat(animalName, animalWeight, livingRegion, breed);
                       
                        //cat.Eat(IFood name);

                    }
                    else if (animalType == nameof(Dog))
                    {
                        string livingRegion = input[3];
                        animal = new Dog(animalName, animalWeight, livingRegion);
                       
                        //dog.Eat(IFood name);

                    }
                    else if (animalType == nameof(Tiger))
                    {
                        string livingRegion = input[3];
                        string breed = input[4];
                        animal = new Tiger(animalName, animalWeight, livingRegion, breed);
                        
                        //tiger.Eat(IFood name);
                    }

                    Console.WriteLine(animal.ProduceSound());
                    animals.Add(animal);

                    IFood food = null;
                    if (foodType==nameof(Meat))
                    {
                        food = new Meat(quantity);
                    }
                    else if (foodType == nameof(Fruit))
                    {
                        food = new Fruit(quantity);
                    }
                    else if (foodType == nameof(Vegetable))
                    {
                        food = new Vegetable(quantity);
                    }
                    else if (foodType == nameof(Seeds))
                    {
                        food = new Seeds(quantity);
                    }

                    animal.Eat(food);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
                input = Console.ReadLine().Split();
            }
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }
    }
}
