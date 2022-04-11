using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP7
{
    public class PortableHidingPlace:GameObject, IHidingPlace, IPortable
    {
        public GameObject item;
        public GameObject HiddenObject { get; set; }
        public int Size { get; set; }

        public PortableHidingPlace(string desc, int i, GameObject item)
        {
            this.Description = desc;
            this.item = new GameObject(desc);
            this.Size = Size;
            this.HiddenObject = item;
            
        }

        public GameObject Search()
        {
            return HiddenObject;
        }
        
    }
}
