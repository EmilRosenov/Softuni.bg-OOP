using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Contracts_Interfaces
{
    public interface ILieutenantGeneral:IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates {get;}
        void AddPrivate(IPrivate @private);
    }
}
