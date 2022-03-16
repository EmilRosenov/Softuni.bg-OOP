using _04.WildFarm.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal
{
    public class Cat : Felines
    {
        public const double CatWeightModifier = 0.30;
        public Cat(string name, 
                   double weight, 
                   string livingRegion, 
                   string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is  Meat || food is Vegetable)
            {
                Weight += food.Quantity * CatWeightModifier;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

       
        public override string ProduceSound()
        => "Meow";

    }
}
