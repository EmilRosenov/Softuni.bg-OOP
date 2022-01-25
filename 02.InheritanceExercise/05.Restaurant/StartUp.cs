using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());
            double grams = double.Parse(Console.ReadLine());
            double calories = double.Parse(Console.ReadLine());
            
            Cake orangeCake = new Cake(name);

            Console.WriteLine(orangeCake.Calories);
            Console.WriteLine(orangeCake.Grams);
            Console.WriteLine(orangeCake.Price);

            Fish fish = new Fish(name, price);
            Console.WriteLine(fish.Grams);
            

        }
    }
}