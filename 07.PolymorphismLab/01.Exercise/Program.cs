using System;

namespace _01.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kitchen do you want to use");
            string kitchenType = Console.ReadLine();

            Kitchen kitchen=null;

            if (kitchenType == "Old")
            {
                kitchen = new OldKitchen();
                
            }
            else if (kitchenType == "Normal")
            {
                kitchen = new NormalKitchen();
            }
            else if (kitchenType == "Modern")
            {

                kitchen = new ModernKitchen();
            }

            while (true)
            {
                Console.WriteLine("What is your order?");

                var order = Console.ReadLine();

                if (order=="meat")
                {
                    kitchen.CookMeat();
                }
                if (order=="salad")
                {
                    kitchen.CutVegetables();
                }
                if (order=="veggie")
                {
                    kitchen.CookVegetables();
                }
                if (order=="clean")
                {
                    kitchen.CleanKitchen();
                }
                if (order == "robot clean")
                {
                    //TODO: add Robot Kitchen
                }
                if (order == "change kitchen")
                {
                    //TODO: change kitchen at any time
                }
                if (order == "that is all")
                {
                    break;

                }
            }
        }
    }
}
