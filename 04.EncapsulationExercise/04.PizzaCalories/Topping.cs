using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Topping
    {
        private const int MinWeight = 1;
        private const int MaxWeight = 50;
        private const int CaloriePerGram = 2;
        private double toppingCalories;
        private int weight;
        private string type;
        
        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
           
        }

        public string Type
        {
            get => this.type;
            private set
            {
                if (value.ToLower()=="meat")
                {
                    this.toppingCalories = 1.2;
                }
                else if (value.ToLower() == "veggies")
                {
                    this.toppingCalories = 0.8;
                }
                else if (value.ToLower() == "cheese")
                {
                    this.toppingCalories = 1.1;
                }
                else if (value.ToLower() == "sauce")
                {
                    this.toppingCalories = 0.9;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }
        public int Weight
        {
            get => this.weight;
            private set
            {
                if (value > MaxWeight || value < MinWeight)
                {
                    throw new ArgumentException($"{Type} weight should be in the range" +
                                                              $"[{MinWeight}..{MaxWeight}].");

                }

                this.weight = value;
            }
        } 
        public double ToppingCalories
        {
            get => this.toppingCalories;
           
        }
        
        public double GetToppingCalories()
        {
            double result = 0;
            result = CaloriePerGram * ToppingCalories * Weight;

            return result;
        }
    }
}
