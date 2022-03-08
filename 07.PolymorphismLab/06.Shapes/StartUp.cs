using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape shape;
            if (new Random().Next() % 2 == 0)
            {
                double height = new Random().Next(3, 9);
                double width = new Random().Next(3, 9);
                shape = new Rectangle(height, width);
            }
            else
            {
                double radius = new Random().Next(2, 9);
                shape = new Circle(radius);
                
            }

            if (shape is Circle)
            {

                try
                {
                    Console.WriteLine($"{((Circle)shape).CalculateArea():F2}");
                    Console.WriteLine($"{((Circle)shape).CalculatePerimeter():F2}");
                    Console.WriteLine(((Circle)shape).Draw());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if(shape is Rectangle rectangle)
            {
                try
                {
                    Console.WriteLine(rectangle.CalculateArea());
                    Console.WriteLine(rectangle.CalculatePerimeter());
                    Console.WriteLine(rectangle.Draw());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
