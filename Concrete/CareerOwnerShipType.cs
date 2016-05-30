using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class OwnerShipType
    {
        public OwnerShipType(int _ID, string _OwnerShipName) 
        {
            ID = _ID;
            OwnerShipName = _OwnerShipName;
        }

        public string OwnerShipName { get; set; }

        public int ID { get; set; }
    }
}
