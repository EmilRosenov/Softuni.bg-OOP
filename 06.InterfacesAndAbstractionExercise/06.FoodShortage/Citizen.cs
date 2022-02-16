using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage
{
    public class Citizen : ICitizen, IBuyer
    {
        private const int BuyingPower = 10;
        private int foodInt;

        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
        }

        public int FoodInt
        {
            get => this.foodInt;

            set => this.foodInt = BuyingPower;

        }

        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public string BirthDate { get; }

        public int BuyFood(int FoodInt)
        {
            int sum = 0;
            sum += FoodInt;
            return sum;
        }
    }
}
