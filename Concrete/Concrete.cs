using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class Concrete
    {
        public Concrete(int _Type, int _Price)
        {
            Type = _Type;
            Price = _Price;
        }

        public int Type
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }
    }
}
