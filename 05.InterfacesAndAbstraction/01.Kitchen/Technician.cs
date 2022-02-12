using _01.Kitchen.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Kitchen
{
    public class Technician
    {
        public IMachinery Kitchen { get; set; }
        List<string> Machineries { get; set; }
        
    }
}
