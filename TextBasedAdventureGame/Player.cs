using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MontanoP7
{
    public class Player
    {
        private int inventorySize;

        List<IPortable> inventory { get; set; }
        MapLocation Location { get; set; }
        public int MaxInventory { get; set; }

        Player(MapLocation location)
        {
            Location = location;
            inventory = new List<IPortable>();
            inventorySize = inventory.Count();
            MaxInventory = 15;
            
        }

        public void Calc()
        {
            inventory.Capacity = this.MaxInventory;
            if (inventorySize> this.MaxInventory )
            {
                MessageBox.Show("Need to drop and item if you" +
                    " want this one");
            }
        }

        public void RemoveInventoryItem()
        {
        }

    }
}
