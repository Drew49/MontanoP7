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
        public int InventorySize
        { get { return inventorySize; } set { inventorySize = value; Calc(); } }

        public List<IPortable> inventory { get; set; }
        public MapLocation Location { get; set; }

        private int maxInventory;
        public int MaxInventory { get { return maxInventory; } set { maxInventory = value; Calc(); } }

        Player ()
        {
            MaxInventory = 5;
        }

        public Player(MapLocation location)
        {
            Location = location;
            inventory = new List<IPortable>();
            inventorySize = inventory.Count();
            MaxInventory = 5;
            
            
        }

        public void Calc()
        {
            //inventory.Capacity = maxInventory;
            //if (inventory.Count> maxInventory )
            //{
             //   MessageBox.Show("Need to drop and item if you" +
              //      " want this one");
            //}
            
            
        }

        public void RemoveInventoryItem(IPortable item)
        {
            inventory.Remove(item);
        }

        public void AddInventoryItem(IPortable item)
        {
            if (inventory.Count < maxInventory)
            {
                var it = new InventoryItem(item.ToString());
                inventory.Add(it);
            }
            else
            {
                MessageBox.Show("Need to drop an item to carry this one");
            }

            
        }

    }
}
