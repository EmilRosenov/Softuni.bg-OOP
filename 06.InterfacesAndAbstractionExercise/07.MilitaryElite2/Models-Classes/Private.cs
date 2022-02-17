using _07.MilitaryElite2.Contracts_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Models_Classes
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName,decimal salary)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; }
        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:f2}"; 
        }
    }
}
