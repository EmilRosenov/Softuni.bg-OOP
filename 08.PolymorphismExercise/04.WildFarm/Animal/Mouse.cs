using _04.WildFarm.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal
{
    public class Mouse : Mammal
    {
        public const double MouseWeightModifier = 0.10;
        public Mouse(string name, 
                    double weight, 
                    string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (food is Fruit || food is Vegetable)
            {
                Weight += food.Quantity * MouseWeightModifier;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            
        }

        public override string ProduceSound()
        => "Squeak";
    }
}
