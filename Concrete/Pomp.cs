using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class Pomp:Machine
    {

        public Pomp( string _plaque, OwnerShipType _ownership,int _RentAmount):base(_plaque,_ownership,_RentAmount)
        {
            /*PompDriverFName = _CareerDriverFName;
            PompDriverLName = _CareerDriverLName;
            plaque = _plaque;
            ownership = _ownership;*/
        }
        
        //public string PompDriverFName { get;set; }

        //public string PompDriverLName { get;set;}

        public Person Driver = new Person();

        public string plaque { get; set; }

        public string ownership { get; set; }

        public string CareerID { get; set; }

        public int RentPrice { get; set; }

        public string GetFullname()
        {
            return Driver.FirstName + " " + Driver.LastName;
        }

    }
}