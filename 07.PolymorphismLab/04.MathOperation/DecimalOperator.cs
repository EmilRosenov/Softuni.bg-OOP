using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class DecimalOperator: MathOperations
    { 
        private decimal a;
        private decimal b;
        private decimal c;

        public DecimalOperator(decimal a, decimal b, decimal c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public override decimal Add(decimal a, decimal b, decimal c)
        {
            decimal sum = this.A + this.B + this.C;
            return sum;
        }

        public decimal A { get; set; }
        public decimal B { get; set; }
        public decimal C { get; set; }
    }
}
