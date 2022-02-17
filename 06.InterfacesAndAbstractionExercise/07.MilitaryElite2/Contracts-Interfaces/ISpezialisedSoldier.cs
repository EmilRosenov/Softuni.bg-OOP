using _07.MilitaryElite2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Contracts_Interfaces
{
    public interface ISpezialisedSoldier:IPrivate
    {
        Corps Corps { get;}
    }
}
