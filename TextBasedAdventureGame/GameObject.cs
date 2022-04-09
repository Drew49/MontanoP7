using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP7
{
    public class GameObject
    {
        public string Desrciption { get; set; }

        public GameObject()
        {
      
        }

        public GameObject(string description)
        {
            this.Desrciption = description;
        }

        public string toString() 
        {
            return Desrciption;
        }
        
    }
}
