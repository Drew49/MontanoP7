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

        public List<IPortable> inventory { get; set; }
        public MapLocation Location { get; set; }
        public int MaxInventory { get; set; }
        Player ()
        {
            MaxInventory = 15;
        }

        public Player(MapLocation location)
        {
            Location = location;
            inventory = new List<IPortable>();
            inventorySize = inventory.Count();
            MaxInventory = 5;
            Calc();
            
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

        public void RemoveInventoryItem(IPortable item)
        {
            inventory.Remove(item);
        }

        public void AddInventoryItem(IPortable item)
        {

            var it = new InventoryItem(item.ToString());
            inventory.Add(it);
            Calc();

            
        }

    }
}
