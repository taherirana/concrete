using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class Machine
    {
        public Machine(string _Plaque, OwnerShipType _ownt, int _RentAmount)
        {
            Plaque = _Plaque;
            MachineOwnerShipType = _ownt;
            RentAmout = _RentAmount;
        }

        public string Plaque { get; set; }
        public OwnerShipType MachineOwnerShipType { get; set; }
        public int RentAmout;
    }
}
