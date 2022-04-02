using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Exercise
{
    public class Cars
    {
        public int Mileage { get; set; }

        public void Drive(int km)
        {
            if (km<=0)
            {
                throw new InvalidOperationException("Don't cheat!");
            }

            Mileage += km;
        }
    }
}
