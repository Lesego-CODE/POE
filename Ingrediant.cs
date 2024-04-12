using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POE
{public class Ingredient
    {
        //Assigning variables
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        //the constructor will initialize an ingrediant
        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
        //the ToString method will be overrided to display the ingrediants
        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name}";
        }
    }
}