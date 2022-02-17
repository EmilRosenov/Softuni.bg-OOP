using _07.MilitaryElite2.Contracts_Interfaces;
using _07.MilitaryElite2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Models_Classes
{
    public class Engineer : SpezialisedSoldier, IEngineer
    {
        private List<IRepair> repairsList;
        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairsList = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => repairsList.AsReadOnly();

        public void AddRepairs(IRepair repair)
        {
            this.repairsList.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.AppendLine($"   {repair}");
            }
            return sb.ToString().TrimEnd(); 
        }
    }
}
