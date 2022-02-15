using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public static class Validator
    {
        public static void ThrowExceptionIfNotValidNumber(string number)
        {
            if (number.Any(x=>char.IsLetter(x)))
            {
                throw new InvalidOperationException("Invalid number!");
            }
        }
        public static void ThrowExceptionIfNotValidUrl(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidOperationException("Invalid URL!");
            }
        }
    }
}
