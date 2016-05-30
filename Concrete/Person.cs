using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class Person
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public List<string> PhoneNumers { get; set; }
        public List<String> Addresses { get; set; }
        public string NationalCode {get;set;}

        public Person(String Fname , String Lname ,string Ncode)
        {
            FirstName = Fname ;
            LastName =  Lname ;
            NationalCode = Ncode;

            InitializeLists();
        }

        public Person(String Fname, String Lname)
        {
            FirstName = Fname;
            LastName = Lname;
            InitializeLists();
        }



        public Person()
        {
            InitializeLists();
        }

        public void AddAddress(string add)
        {
            Addresses.Add(add);
        }

        public void AddPhoneNumber(string Phone)
        {
            PhoneNumers.Add(Phone);
        }

        public void InitializeLists()
        {
            Addresses = new List<string>();
            PhoneNumers = new List<string>();
        }
    }
}