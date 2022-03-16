using _04.WildFarm.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal
{
    public class Dog : Mammal
    {
        public const double DogWeightModifier = 0.4;
        public Dog(string name,
                   double weight,
                   string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Meat)
            {
                Weight += food.Quantity * DogWeightModifier;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            
        }

        public override string ProduceSound()
        => "Woof!";
    }
}
