using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class SellItem
    {
        public string CustomerName { get; set; }
        //public string MixerDriverName { get; set; }
        //public string CareeDriverName { get; set; }

        public int MixerID { get; set; }
        public int CareerID { get; set; }

        public string ConcreteType { get; set; }
        public string Operation { get; set; }
        public string Address { get; set; }

        public float WeightInTon { get; set; }
        public float WeightInM2 { get; set; }
        public float price { get; set; }
        
        public string BillNumer { get; set; }
        
        public float MixerEmpetyWeight { get; set; }
        public float FullWeight { get; set; }
        public float MixerNetWeight { get; set; }
        
        public float MixerWeightingWeight { get; set; }

        public OwnerShipType ownerShipType { get; set; }
        public int MixerRentPrice { get; set; }


        public SellItem(string _CustomerName, int _MixerID, int _CareerID, string _ConcreteType, string _Operation, string _Address, float _WeightInTon, float _WeightInM2, float _price)
        {
            CustomerName = _CustomerName;
            MixerID = _CareerID;
            CareerID = _MixerID;
            ConcreteType = _ConcreteType;
            Operation = _Operation;
            Address = _Address;

            WeightInTon = _WeightInTon;
            WeightInM2 = _WeightInM2;
            price = _price;
        }


        public void SetCareerDetail(string ID)
        {
            //CareerID = 
        }
    }
}
