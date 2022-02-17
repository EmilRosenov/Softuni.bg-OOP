using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Contracts_Interfaces
{
    public interface IEngineer:ISpezialisedSoldier
    {
        IReadOnlyCollection<IRepair>Repairs { get; }
        void AddRepairs(IRepair repair);
    }
}
