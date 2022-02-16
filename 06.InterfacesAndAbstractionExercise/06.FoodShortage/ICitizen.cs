using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage
{
    public interface ICitizen
    {
        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public string BirthDate { get; }
    }
}
