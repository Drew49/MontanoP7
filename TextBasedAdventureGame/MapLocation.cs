// GameLocation
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
    /// <summary>
    /// Represents a location on the map
    /// </summary>
    public class MapLocation
    {
        
        public string Description { get; set; }
        public List<TravelOption> TravelOptions { get; set; }
        public List<GameObject> Items { get; set; }
        public MapLocation(string description)
        {
            Description = description;
            TravelOptions = new List<TravelOption>();
            Items = new List<GameObject>();
        }

        public override string ToString()
        {
            return Description;
        }
    }
}
