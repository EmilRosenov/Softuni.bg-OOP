using System;

namespace _03.ExerciseKeyWord_Is
{
    public class Program
    {
        static void Main(string[] args)
        {

            Shape shape;
            if (new Random().Next() %2==0)
            {
                shape = new Rectangle();
            }
            else
            {
                shape = new Circle();
            }

            if (shape is Circle)
            {
                shape.Draw();
                Console.WriteLine($"The radius is {((Circle)shape).Radius}");
            }
            else if(shape is Rectangle)
            {
                shape.Draw();
                Console.WriteLine($"surface area is {((Rectangle)shape).Height}*{((Rectangle)shape).Width}");
            }
        }
    }
}
