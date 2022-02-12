using _01.Kitchen.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Kitchen
{
    public class Kitchen:IOrderable,IMachinery,ICalculatable
    {
       
        public List<string> Machineries { get; set; }
        public Kitchen()
        {
            Machineries = new List<string>();
        }
        
        public void AddMachinery(string machineryName)
        {
            Machineries.Add(machineryName);
        }
        public void OrderMeal(string mealName)
        {
            Console.WriteLine($"Meal {mealName} ordered!");
        }
        public void AddProduct(string productName)
        {
            Console.WriteLine($"Meal {productName} ordered!");
        }
        public void CalucaleCost()
        {
            Console.WriteLine("The current cost is: Too Much");
        }
        public void ListAllMachineries()
        {
            
            
                Console.WriteLine(string.Join(", ",Machineries));
            
        }
    }
}
