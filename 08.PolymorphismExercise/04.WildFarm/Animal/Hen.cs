using _04.WildFarm.Food;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal
{
    public class Hen : Bird
    {
        public const double HenWeightModifier = 0.35;
        public Hen(string name,
                   double weight,
                   double wingSize)
                   : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            
            Weight += food.Quantity * HenWeightModifier;
            this.FoodEaten += food.Quantity;
        }

        
        public override string ProduceSound()
        => "Cluck";

    }
}
