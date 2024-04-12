using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POE
{
    public class Step
    {
        public string Description { get; set; }
        
        // Constructor to initialize a step
        public Step(string description)
        {
            Description = description;
        }
        
        // Override ToString method to display step description
        public override string ToString()
        {
            return Description;
        }
    }
}