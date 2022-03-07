using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class DoubleOperator : MathOperations
    {
        private double a;
        private double b;
        private double c;

        public DoubleOperator(double a, double b, double c)
        {
           this.A = a;
           this.B = b;
           this.C = c;
        }

        public override double Add(double a, double b, double c)
        {
            double sum = this.A + this.B + this.C;
            return sum;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
    }
}
