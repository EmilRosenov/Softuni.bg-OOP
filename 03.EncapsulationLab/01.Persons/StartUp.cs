using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                string secondName = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person(name, secondName, age);
                persons.Add(person);
            }

            persons = persons.OrderBy(x => x.FirstName).ThenBy(x => x.Age).ToList();

            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
        }
    }
}
