using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string url)
        {
            Validator.ThrowExceptionIfNotValidUrl(url);
            return $"Browsing: {url}!";
        }

        public string Call(string number)
        {
            Validator.ThrowExceptionIfNotValidNumber(number);
            return $"Calling... {number}";
        }
    }
}
