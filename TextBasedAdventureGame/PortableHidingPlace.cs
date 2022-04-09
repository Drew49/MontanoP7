using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP7
{
    public class PortableHidingPlace:GameObject, IHidingPlace, IPortable
    {
        GameObject item;
        public GameObject HiddenObject { get; set; }
        public int Size { get; set; }

        public void Search()
        {
            HiddenObject = item;
        }
        
    }
}
