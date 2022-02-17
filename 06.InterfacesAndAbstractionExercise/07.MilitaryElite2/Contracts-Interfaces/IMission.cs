using _07.MilitaryElite2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Contracts_Interfaces
{
    public interface IMission
    {
        string CodeName { get; }
        MissionState MissionState { get; }
        void CompleteMission();
    }
}
