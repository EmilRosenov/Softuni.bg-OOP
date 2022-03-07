using System;
using System.Collections.Generic;
using System.Text;

namespace Operations
{
    public class IntOperator : MathOperations
    {
        private int a;
        private int b;

        public IntOperator(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public int A { get; set; }
        public int B { get; set; }

        public override int Add(int a, int b)
        {
            int sum = this.A + this.B;
            return sum;
        }
    }

}

