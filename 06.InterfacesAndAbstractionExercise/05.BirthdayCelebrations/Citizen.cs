using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Citizen:IBirthable,IIdentifiable,INameable
    {
        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
        }

        public string Name { get;}
        public int Age { get;}
        public string Id { get;}
        public string BirthDate { get;}


    }
}
