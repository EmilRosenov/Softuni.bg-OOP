using System;
using System.Collections.Generic;

namespace _04.PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine()
                .Split();
            string name = input1[1];
            string[] input2 = Console.ReadLine()
               .Split();
            string doughType = input2[1];
            string doughBakingStyle = input2[2];
            int grams = int.Parse(input2[3]);
            try
            {
                Dough dough = new Dough(doughType, doughBakingStyle, grams);
                Pizza pizza = new Pizza(name, dough);
                
                string[] input3 = Console.ReadLine()
              .Split();
                while (input3[0] != "END")
                {
                    string toppingName = input3[1];
                    int toppingWeight = int.Parse(input3[2]);

                    Topping topping = new Topping(toppingName, toppingWeight);
                    pizza.AddTopping(topping);

                    input3 = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories():f2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
           
            
        }
    }
}
