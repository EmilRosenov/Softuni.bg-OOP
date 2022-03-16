using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, 
                        double weight,
                        string livingRegion) 
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion { get; set; }
        public string FoodToEat { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
