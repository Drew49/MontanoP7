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

        public HidingPlace(string desc)
        {
            this.Description = desc;
            this.hiddenObject = new GameObject(desc);
        }

        public void Search()
        {
            HiddenObject = hiddenObject;
        }
    }
}
