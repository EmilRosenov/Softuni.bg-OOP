using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.TelephonyUpgraded
{
    public static class Validator
    {
        public static void ThrowIfInvalidNumber(string number)
        {
            if (number.Any(x=> !char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid number!");
            }
        }
    }
}
