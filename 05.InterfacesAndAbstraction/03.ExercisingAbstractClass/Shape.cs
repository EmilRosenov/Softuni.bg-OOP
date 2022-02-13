
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ExercisingAbstractClass
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Draw();

        public  virtual void PrintName()
        {
            Console.WriteLine("Printing name of shape: Shape");
        }
       
    }
}
