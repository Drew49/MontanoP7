using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP7
{
    class PortableHidingPlace:GameObject, IHidingPlace, IPortable
    {
        public GameObject item;
        public GameObject HiddenObject { get; set; }
        public int Size { get; set; }

        public void Search()
        {
            HiddenObject = new GameObject();
        }
        
    }
}
