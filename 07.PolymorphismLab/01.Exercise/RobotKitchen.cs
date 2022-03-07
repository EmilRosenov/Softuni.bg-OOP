using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Exercise
{
    public class RobotKitchen : ModernKitchen, IRobotCleaner
    {
       
        public void RobotClean()
        {
            Console.WriteLine("RoboKitchen: robot clean");
        }
    }
}
