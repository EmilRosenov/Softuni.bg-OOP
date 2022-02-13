using System;

namespace _03.ExercisingAbstractClass
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle();
            Shape circle = new Circle();
            Shape triangle = new Triangle("Scalene");

            rectangle.Draw();
            rectangle.PrintName();
            rectangle.X = 4;
            rectangle.Y = 6;

            circle.Draw();
            circle.PrintName();

            triangle.Draw();
            triangle.PrintName();
        }
    }
}
