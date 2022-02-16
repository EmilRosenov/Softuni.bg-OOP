using System;
using System.Collections.Generic;
using System.Text;

namespace _03.TelephonyUpgraded
{
    public abstract class Phone:ICallable
    {
       public abstract string Call(string number);

    }
}
