using _04.WildFarm.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal
{
    public class Owl : Bird
    {
        public const double OwlWeightModifier = 0.25;
        public Owl(string name,
                   double weight,
                   double wingSize)
                   : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Meat)
            {
                Weight += food.Quantity * OwlWeightModifier;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            
        }


        public override string ProduceSound()
        => "Hoot Hoot";

    }
}
