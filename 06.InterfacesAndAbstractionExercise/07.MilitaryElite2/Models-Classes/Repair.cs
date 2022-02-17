using _07.MilitaryElite2.Contracts_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Models_Classes
{
    public class Repair : IRepair
    {
        //private IReadOnlyList<IRepair> reprairsList;
        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; private set; }

        public int HoursWorked { get; private set; }
        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}
