using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Exercise
{
    public class NormalKitchen : Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("In NORMAL KITCHEN: vacuum cleaning and dusting");
        }

        public override void CookMeat()
        {
            Console.WriteLine("In NORMAL KITCHEN: turn the heat on an put the meat");
        }
        public override void CutVegetables()
        {
            Console.WriteLine("In NORMAL KITCHEN: Cutting the vegetables");
        }
        public override void CookVegetables()
        {
            Console.WriteLine("In NORMAL KITCHEN: grilling the vegetables");
        }
    }
}
