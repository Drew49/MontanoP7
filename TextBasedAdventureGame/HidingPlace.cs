using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP7
{
    public class HidingPlace: GameObject, IHidingPlace 
    {
        private GameObject hiddenObject;
        public GameObject HiddenObject { get; set; }

        public HidingPlace()
        {
            hiddenObject = null;
        }

        public void Search()
        {
            HiddenObject = hiddenObject;
        }
    }
}
