using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Exercise
{
    public abstract class Kitchen
    {
        public abstract void CleanKitchen();
        public virtual void CookVegetables()
        {
            Console.WriteLine("In  tha abstract class Kitchen: grilling the vegetables");
        }
        public abstract void CookMeat();
        public virtual void CutVegetables() 
        {
            Console.WriteLine("Cutting the vegetables");
        }
      
    }
}
