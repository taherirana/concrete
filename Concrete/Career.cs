using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class Career
    {

        public Career(string _CareerDriverFName, string _CareerDriverLName, string _plaque, string _ownership)
        {
            CareerDriverFName = _CareerDriverFName;
            CareerDriverLName = _CareerDriverLName;
            plaque = _plaque;
            ownership = _ownership;
        }
        
        public string CareerDriverFName { get;set; }

        public string CareerDriverLName { get;set;}

        public string plaque { get; set; }

        public string ownership { get; set; }

        public string CareerID { get; set; }
    }
}