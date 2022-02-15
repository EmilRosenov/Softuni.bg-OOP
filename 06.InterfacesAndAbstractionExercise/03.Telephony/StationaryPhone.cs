using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Telephony
{
    public class StationaryPhone:ICallable
    {
        
        public string Call(string number)
        {
            Validator.ThrowExceptionIfNotValidNumber(number);
            return $"Dialing... {number}";
        }
    }
}
