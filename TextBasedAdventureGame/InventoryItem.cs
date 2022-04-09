using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP7
{
    public class InventoryItem: GameObject,IPortable
    {
        public int Size { get; set; }

        public InventoryItem():base()
        {
            
        }

    }
}
