using System;
using System.Collections.Generic;

namespace _04.BorderControl
{
    public class Program
    {
        static void Main()
        {
            List<string> detainedIds = new List<string>();
            Dictionary<string, string> entryList = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0]=="End")
                {
                    break;
                }

                string name = input[0];
                if (input.Length== 3)
                {
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    Human human = new Human(name, age, id);
                    entryList.Add(human.Name, human.Id);
                }
                else
                {
                    string id = input[1];
                    Robot robot = new Robot(name, id);
                    entryList.Add(robot.Name, robot.Id);
                }
            }

            string givenNumber = Console.ReadLine();
            int lenght = givenNumber.Length;

            foreach (var IdNumber in entryList.Values)
            {
                if (IdNumber.Contains(givenNumber)
                    && IdNumber.EndsWith(givenNumber))
                {
                    detainedIds.Add(IdNumber);
                }
            }
            if (detainedIds.Count==0)
            {
                Console.WriteLine();
            }
            else
            {
                foreach (var item in detainedIds)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
