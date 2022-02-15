using System;
using System.Collections.Generic;

namespace _04.BorderControlBetterVersion
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> detainedIds = new List<IIdentifiable>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }

                string name = input[0];
                if (input.Length == 3)
                {
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    IIdentifiable human = new Human(name, age, id);
                    detainedIds.Add(human);
                }
                else
                {
                    string id = input[1];
                    IIdentifiable robot = new Robot(name, id);
                    detainedIds.Add(robot);
                }
            }

            string givenNumber = Console.ReadLine();

            foreach (var item in detainedIds)
            {
                if (item.Id.EndsWith(givenNumber))
                {
                    Console.WriteLine(item.Id);
                }
            }
        }
    }
}
