using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage
{
    public class Rebel:IRebel,IBuyer
    {
        private const int BuyingPower = 5;
        private int foodInt;

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; }

        public int Age { get; }

        public string Group { get; }
        public int FoodInt
        {
            get => this.foodInt;

            set => this.foodInt = BuyingPower;

        }

        public int BuyFood(int FoodInt)
        {
            int sum = 0;
            sum += FoodInt;
            return sum;
        }
    }
}
