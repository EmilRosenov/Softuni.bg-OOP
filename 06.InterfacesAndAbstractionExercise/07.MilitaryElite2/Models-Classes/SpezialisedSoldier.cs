using _07.MilitaryElite2.Contracts_Interfaces;
using _07.MilitaryElite2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Models_Classes
{
    public abstract class SpezialisedSoldier : Private, ISpezialisedSoldier
    {
        protected SpezialisedSoldier(string id,
                                  string firstName,
                                  string lastName,
                                  decimal salary,
                                  Corps corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public Corps Corps { get; private set; }
        public override string ToString()
        {
            return base.ToString() +
                Environment.NewLine +
                $"Corps: {this.Corps}";
        }
    }
}
