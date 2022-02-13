using System;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();

            IIdentifiable person = new Citizen(name, age, id, birthdate);
            Console.WriteLine(person.Id);
            IBirthable otherPerson = new Citizen(name, age, id, birthdate);
            Console.WriteLine(otherPerson.Birthdate);


        }
    }
}
