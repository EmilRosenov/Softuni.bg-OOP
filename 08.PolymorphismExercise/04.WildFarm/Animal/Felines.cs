using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal
{
    public abstract class Felines : Mammal
    {
        protected Felines(string name, 
                          double weight, 
                          string livingRegion,
                          string breed) 
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }
        public string Breed { get; set; }
        //public string FoodToEat { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
