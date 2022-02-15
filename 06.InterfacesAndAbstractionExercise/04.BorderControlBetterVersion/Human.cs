using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControlBetterVersion
{
    public class Human : IIdentifiable
    {
        public Human(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; }
    }
}
