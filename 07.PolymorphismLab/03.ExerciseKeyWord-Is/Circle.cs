using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ExerciseKeyWord_Is
{
    public class Circle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw circle");
           
        }

        public int Radius { get; set; }
    }
}
