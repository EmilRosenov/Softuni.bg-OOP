using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ExerciseKeyWord_Is
{
    public class Rectangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw rectangle");
        }
        public int Height { get; set; }
        public int Width { get; set; }
    }
}
