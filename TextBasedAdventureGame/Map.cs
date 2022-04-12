// TravelOption
// Programer: Rob Garner (rgarner7@cnm.edu)
// Date: 25 May 2016
// Represents a travel option.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace MontanoP7
{
    /// <summary>
    /// Class that represents the game. 
    /// Has a map and location of player.
    /// </summary>
    public class Map
    {
        /// <summary>
        /// List of map locations.
        /// </summary>
        public List<MapLocation> Locations { get; set; }

        /// <summary>
        /// Player's location.
        /// </summary>
        

        /// <summary>
        /// Constructor that creates the game map.
        /// </summary>
        public Map()
        {
            //Create map locations first
            Locations = new List<MapLocation>();           
            Locations.Add(new MapLocation("You are on a road leading to a town."));
            Locations.Add(new MapLocation("You are on a road in front of a saloon."));
            Locations.Add(new MapLocation("You are in a saloon."));
            Locations.Add(new MapLocation("You are on a road in front of a jail."));
            Locations.Add(new MapLocation("You are in a jail."));
            Locations.Add(new MapLocation("You are on a road in front of a general store."));
            Locations.Add(new MapLocation("You are in a general store."));
            Locations.Add(new MapLocation("You are now behind the general store and see a bank and the general store"));
            Locations.Add(new MapLocation("You are in the bank"));
            

            //Now add travel options to each map location

            //Road outside town
            Locations[0].TravelOptions.Add(new TravelOption("A town is to the west of you.",Locations[1]));

            //Road in front of salloon
            Locations[1].TravelOptions.Add(new TravelOption("The road out of town is to the east of you.", Locations[0]));            
            Locations[1].TravelOptions.Add(new TravelOption("A salloon is to the north of you.", Locations[2]));            
            Locations[1].TravelOptions.Add(new TravelOption("A road leading further into town is to the west of you.", Locations[3]));

            //Salloon
            Locations[2].TravelOptions.Add(new TravelOption("The saloon door leads out to the street.", Locations[1]));

            //Road in front of jail
            Locations[3].TravelOptions.Add(new TravelOption("A road is to the east of you.", Locations[1]));
            Locations[3].TravelOptions.Add(new TravelOption("A jail is to the north of you.", Locations[4]));
            Locations[3].TravelOptions.Add(new TravelOption("A road leading further into town is to the west of you.", Locations[5]));

            //Jail
            Locations[4].TravelOptions.Add(new TravelOption("The jail door leads out to the street.", Locations[3]));

            //Road in front of general store
            Locations[5].TravelOptions.Add(new TravelOption("A road is to the east of you.", Locations[3]));
            Locations[5].TravelOptions.Add(new TravelOption("A general store is to the north of you.", Locations[6]));

            //General Store
            Locations[6].TravelOptions.Add(new TravelOption("The store door leads out to the street.", Locations[5]));
            Locations[6].TravelOptions.Add(new TravelOption("The back door leads to an alley way", Locations[7]));

            //Ally way
            Locations[7].TravelOptions.Add(new TravelOption("The bank is to the north", Locations[8]));
            Locations[7].TravelOptions.Add(new TravelOption("The general store is to the south", Locations[6]));

            //bank
            Locations[8].TravelOptions.Add(new TravelOption("The back door leads to the road out of town", Locations[0]));

            //Add items
            Locations[0].Items.Add(new InventoryItem("Broken Rifle"));
            Locations[1].Items.Add(new InventoryItem("Beer glass"));
            Locations[2].Items.Add(new InventoryItem("Bar Stool"));
            Locations[3].Items.Add(new InventoryItem("Get out of jail card"));
            Locations[4].Items.Add(new InventoryItem("Hammer"));


            HidingPlace rock = new HidingPlace("Large Rock");
            rock.HiddenObject = new InventoryItem("Ninja Star");
            Locations[0].Items.Add(rock);

            HidingPlace counter = new HidingPlace("Bar counter");
            counter.HiddenObject = new InventoryItem("First aid kit");
            Locations[2].Items.Add(counter);

            HidingPlace jailCell = new HidingPlace("Jail cell");
            jailCell.HiddenObject = new InventoryItem("Metal file");
            Locations[4].Items.Add(jailCell);

            HidingPlace cashReG = new HidingPlace("Cash register");
            cashReG.HiddenObject = new InventoryItem("$100 in cash");
            Locations[6].Items.Add(cashReG);

            Locations[8].Items.Add(new PortableHidingPlace("Bank bag", 1, new InventoryItem("$20 in cash")));
            Locations[5].Items.Add(new PortableHidingPlace("Saddle bag", 1, new InventoryItem("Sheriff's badge")));
            
           
        }

    }
}
