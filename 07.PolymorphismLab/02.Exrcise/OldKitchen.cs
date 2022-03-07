using System;
using System.Collections.Generic;
using System.Text;

namespace _02.Exercise
{
    public class OldKitchen : Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("In OLDKITCHEN: clean and throw the rubbish");
        }

        public override void CookMeat()
        {
            Console.WriteLine("In OLDKITCHEN: throw in the open fire pit");
        }

        public override void CookVegetables()
        {
            Console.WriteLine("In OLDKITCHEN: put in a scewers and rotate in the pit");
        }
        public override void CutVegetables()
        {
            Console.WriteLine("In OLDKITCHEN: Cutting the vegetables");
        }
    }
}
