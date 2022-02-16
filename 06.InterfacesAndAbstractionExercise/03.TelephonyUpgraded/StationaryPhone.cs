using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.TelephonyUpgraded
{
    public class StationaryPhone : Phone
    {
        public override string Call(string number)
        {
            Validator.ThrowIfInvalidNumber(number);
            return $"Dialing... {number}";
        }
    }
}
