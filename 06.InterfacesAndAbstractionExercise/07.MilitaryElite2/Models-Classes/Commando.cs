using _07.MilitaryElite2.Contracts_Interfaces;
using _07.MilitaryElite2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Models_Classes
{
    public class Commando : SpezialisedSoldier, ICommando
    {
        private List<IMission> missionsList;
        public Commando(string id,
                        string firstName,
                        string lastName,
                        decimal salary,
                        Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            missionsList = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> MissionList => missionsList.AsReadOnly();

        public string CodeName { get; private set; }

        public MissionState MissionState { get; private set; }

        public void AddMission(IMission mission)
        {
            missionsList.Add(mission);
        }

        public void CompleteMission()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Missions:");

            foreach (var mission in missionsList)
            {
                sb.AppendLine($"  {mission}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
