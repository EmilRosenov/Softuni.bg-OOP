using System;
using System.Collections.Generic;
using System.Text;

namespace Operations 
{
    public class MathOperations
    {
        public virtual int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public virtual double Add(double a, double b, double c)
        {
            double sum = a + b + c;
            return sum;
        }
        public virtual decimal Add(decimal a, decimal b, decimal c)
        {
            decimal sum = a + b + c;
            return sum;
        }
    }
}
