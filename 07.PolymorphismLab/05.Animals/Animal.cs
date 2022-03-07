using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public Animal(string name, string favFood)
        {
            Name = name;
            FavFood = favFood;
        }

        public string Name { get; set; }
        public string FavFood { get; set; }

        public abstract string ExplainSelf();

        public override string ToString()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavFood}";
        }
    }
}
