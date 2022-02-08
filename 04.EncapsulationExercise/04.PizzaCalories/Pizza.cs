using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.PizzaCalories
{
    public class Pizza
    {
        private const int MaxToppingCount = 10; 
        private const int MaxLength = 15; 
        private const int MinLength = 1; 
        private string name;
        public Dough Dough;
        public List<Topping> toppingList;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppingList = new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length < 1 || value.Length >15)
                {
                    throw new ArgumentException($"Pizza name should be between {MinLength} and {MaxLength} symbols.");
                }
                this.name = value;
            }    
        }
        public void AddTopping(Topping topping)
        {
            if (toppingList.Count > MaxToppingCount)
            {
                throw new ArgumentException($"Number of toppings should be in range [0..{MaxToppingCount}].");
            }
            toppingList.Add(topping);
        }

        public double TotalCalories()
        {
            double result = Dough.GetCalories() + toppingList.Sum(t=>t.GetToppingCalories());
            
            return result;
        }
        
    }
}
