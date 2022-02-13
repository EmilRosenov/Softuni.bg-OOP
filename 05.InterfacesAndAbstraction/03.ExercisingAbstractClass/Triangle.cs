using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ExercisingAbstractClass
{
    public class Triangle : Shape
    {
        public Triangle(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Drawing a triangle");
        }
    }
}
