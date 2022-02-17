using _07.MilitaryElite2.Contracts_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite2.Models_Classes
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName,int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.Codenumber = codeNumber;
        }

        public int Codenumber { get; private set; }
        public override string ToString()
        {
            return base.ToString() +
                   Environment.NewLine +
                   $"Code Number: {this.Codenumber}";
        }
    }
}
