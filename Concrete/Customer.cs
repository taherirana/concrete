using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class Customer
    {
        public Customer(string _FirstName , string _LastName , String _IDCode )
        {
            Firstname = _FirstName;
            LastName = _LastName;
            IDCode = _IDCode;
          
            Phones = new List<string>();
            Addresses = new List<string>();  
          
        }

        public int CustomerID
        {
            get;
            set;
        }

        public void AddPhone(String PhoneNumber)
        {
            Phones.Add(PhoneNumber);
        }

        public void AddAddress(string _Address)
        {
            Addresses.Add(_Address);
        }

        public string Firstname
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string IDCode
        {
            get;
            set;
        }

        public List<string> Phones
        {
            get;
            set;
        }

        public List<string> Addresses
        {
            get;
            set;
        }
    }
}
