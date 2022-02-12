using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Kitchen.Contracts
{
    public interface IMachinery
    {
        List<string> Machineries { get; set; }
        void AddMachinery(string machineryName);
        void ListAllMachineries();
        



    }
}
