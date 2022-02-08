using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private const int MinGrams = 1;
        private const int MaxGrams = 200;
        private string doughType;
        private string doughBakingStyle;
        private double calories;
        private double bakingStyleCalories;
        private int doughWeight;

        public Dough(string doughType, string doughBakingStyle, int doughWeight)
        {
            DoughType = doughType;
            DoughBakingStyle = doughBakingStyle;
            DoughWeight = doughWeight;
        }

        public string DoughType
        {
            get => this.doughType; 
            private set 
            {
                if (value == "White")
                {
                    this.calories = 1.50;
                }
                else if (value == "Wholegrain")
                {
                    this.calories = 1.0;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                   
                }

                this.doughType = value;
            }
        }
        public string DoughBakingStyle
        {
            get => this.doughBakingStyle;
            private set
            {
                if (value.ToLower() =="crispy")
                {
                    this.bakingStyleCalories = 0.9;
                }
                else if (value.ToLower() == "chewy")
                {
                    this.bakingStyleCalories = 1.1;
                }
                else if (value.ToLower() == "homemade")
                {
                    this.bakingStyleCalories = 1.0;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.doughBakingStyle = value;
            }
        }
        public double BakingStyleCalories
        {
            get => this.bakingStyleCalories;
        }
        public int DoughWeight
        {
            get => doughWeight;
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinGrams}..{MaxGrams}].");
                }

                this.doughWeight = value;
            }
        }

        public double GetCalories()
        {
            double result = 0;
            result = (2 * DoughWeight) * BakingStyleCalories * Calories;
            return result;
        }

        private double Calories
        {
            get => this.calories;
           
        }
    }
}
