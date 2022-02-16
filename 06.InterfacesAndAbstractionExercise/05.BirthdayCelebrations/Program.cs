using System;
using System.Collections.Generic;

namespace _05.BirthdayCelebrations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IBirthable> birthdayDatesObjects = new List<IBirthable>();
            List<IIdentifiable> identifiableObjects = new List<IIdentifiable>();
            List<INameable> nameableObjects = new List<INameable>();

            while (true)
            {
                
                string[] input = Console.ReadLine().Split();

                if (input[0]=="End")
                {
                    break;
                }

                string type = input[0];

                if (type== "Citizen")
                {
                    string name = input[1];
                    int age = int.Parse(input[2]);
                    string id = input[3];
                    string birthDate = input[4];
                    IBirthable person = new Citizen(name, age, id, birthDate);
                    IIdentifiable identifiablePerson = new Citizen(name, age, id, birthDate);
                    INameable nameablePerson =new Citizen(name, age, id, birthDate);
                    birthdayDatesObjects.Add(person);
                    identifiableObjects.Add(identifiablePerson);
                    nameableObjects.Add(nameablePerson);

                }
                else if (type == "Pet")
                {
                    string name = input[1];
                    string birthDate = input[2];
                    IBirthable pet = new Pet(name, birthDate);
                    INameable nameablePet = new Pet(name, birthDate);
                    birthdayDatesObjects.Add(pet);
                    nameableObjects.Add(nameablePet);
                }
                else if (type == "Robot")
                {
                    string model = input[1];
                    string id = input[2];
                    IIdentifiable robot = new Robot(model, id);
                    identifiableObjects.Add(robot);
                }
            }
            string yearGiven = Console.ReadLine();

            foreach (var item in birthdayDatesObjects)
            {
                if (item.BirthDate.EndsWith(yearGiven))
                {
                    Console.WriteLine(item.BirthDate);
                }
            }
           
        }
    }
}
