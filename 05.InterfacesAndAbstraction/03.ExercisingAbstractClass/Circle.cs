using System;
using System.Web;

namespace _03.ExercisingAbstractClass
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
        public override void PrintName()
        {
            Console.WriteLine("Printing After being Ovverridden!!!");
        }
    }
}
