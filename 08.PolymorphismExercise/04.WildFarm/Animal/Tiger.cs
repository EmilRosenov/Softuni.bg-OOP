using _04.WildFarm.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal
{
    public class Tiger:Felines
    {
        public const double TigerWeightModifier = 1;
        public Tiger(string name,
                   double weight,
                   string livingRegion,
                   string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Meat)
            {
                Weight += food.Quantity * TigerWeightModifier;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

        }

        public override string ProduceSound()
        => "ROAR!!!";

    }
}
