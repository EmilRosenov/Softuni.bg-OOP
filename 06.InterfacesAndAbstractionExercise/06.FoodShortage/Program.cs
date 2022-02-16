using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoodShortage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> NameAndFoodAmount = new Dictionary<string, int>();
            List<string> rebelsList = new List<string>();
            List<string> citizensList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (input.Length==4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string bDate = input[3];
                    Citizen citizen = new Citizen(name, age, id, bDate);
                    NameAndFoodAmount.Add(citizen.Name, citizen.BuyFood(0));
                    citizensList.Add(citizen.Name);
                }
                else if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];
                    Rebel rebel = new Rebel(name, age, group);
                    NameAndFoodAmount.Add(rebel.Name, rebel.BuyFood(0));
                    rebelsList.Add(rebel.Name);
                }
            }

            while (true)
            {
                string name = Console.ReadLine();

                if (name=="End")
                {
                    break;
                }

                if (NameAndFoodAmount.ContainsKey(name))
                {
                    if (rebelsList.Contains(name))
                    {
                        NameAndFoodAmount[name]+=5;
                    }
                    else if (citizensList.Contains(name))
                    {
                        NameAndFoodAmount[name] += 10;
                    }
                }
            }

            Console.WriteLine(NameAndFoodAmount.Values.Sum());
        }
    }
}
