using _01.Kitchen.Contracts;
using System;

namespace _01.Kitchen
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mealName = Console.ReadLine();
            int machinesListCount = int.Parse(Console.ReadLine());

           
           

            Kitchen kitchen = new Kitchen();
            IOrderable waiter = new Kitchen();
            waiter.OrderMeal(mealName);

            ICalculatable ceo = new Kitchen();
            ceo.CalucaleCost();
            IMachinery technician = new Kitchen();
            
            for (int i = 0; i < machinesListCount; i++)
            {
                string machineryName = Console.ReadLine();

                technician.AddMachinery(machineryName);

            }
            technician.ListAllMachineries();

            
        }
    }
}
