using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class SellItem
    {
        public string CustomerName { get; set; }
        public string MixerDriverName { get; set; }
        public string CareeDriverName { get; set; }
        public string ConcreteType { get; set; }
        public string Operation { get; set; }
        public string Address { get; set; }

        public float WeightInTon { get; set; }
        public float WeightInM2 { get; set; }
        public float price { get; set; }




        public SellItem(string _CustomerName, string _MixerDriverName, string _CareeDriverName, string _ConcreteType, string _Operation, string _Address, float _WeightInTon, float _WeightInM2, float _price)
        {
            CustomerName = _CustomerName;
            MixerDriverName = _MixerDriverName;
            CareeDriverName = _CareeDriverName;
            ConcreteType = _ConcreteType;
            Operation = _Operation;
            Address = _Address;

            WeightInTon = _WeightInTon;
            WeightInM2 = _WeightInM2;
            price = _price;
        }
    }
}
