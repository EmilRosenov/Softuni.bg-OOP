using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const decimal CoffeePrice = 3.50M;
        private const double  CoffeeMililiters = 3.50;
        public Coffee(string name,double caffeine) 
            : base(name, CoffeePrice, CoffeeMililiters)
        {
            this.Caffeine = caffeine;
        }
        public double Caffeine { get; set; }
    }
}
