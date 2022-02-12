using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Kitchen.Contracts
{
    public interface IOrderable
    {
        void OrderMeal(string mealName);
    }
}
