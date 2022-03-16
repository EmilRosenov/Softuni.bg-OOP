using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animal
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight,double wingSize) 
            : base(name, weight)
        {
            this.WingSize = wingSize;
        }
        public double WingSize { get; set; }
        
        public override string ToString()
        {
            return $"{this.GetType().Name} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
