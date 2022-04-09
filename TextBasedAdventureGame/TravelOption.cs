// TravelOption
// Programer: Rob Garner (rgarner7@cnm.edu)
// Date: 25 May 2016
// Represents a travel option.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP7
{
   
    public class TravelOption
    {
       
        public string Description { get; set; }

        
        public MapLocation Location { get; set; }

        
        public TravelOption(string description, MapLocation location)
        {
            Description = description;
            Location = location;
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
