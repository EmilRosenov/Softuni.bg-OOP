using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoodShortageUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> buyersByNAme = new Dictionary<string, IBuyer>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length==3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];
                    Rebel rebel = new Rebel(group, name, age);
                    buyersByNAme[name] = rebel;
                }
                else
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthDate = input[3];
                    Citizen citizen = new Citizen(name, age, id, birthDate);
                    buyersByNAme[name] = citizen;
                }
            }

            while (true)
            {
                string givenName = Console.ReadLine();
                if (givenName=="End")
                {
                    break;
                }

                if (buyersByNAme.ContainsKey(givenName))
                {
                    buyersByNAme[givenName].BuyFood();
                }
            }

            Console.WriteLine(buyersByNAme.Values.Sum(x=>x.Food));
        }
    }
}
