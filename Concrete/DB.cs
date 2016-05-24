using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class DB
    {
         
    }

    public interface IDatabase
    {
        public bool InserCustomer();
        
        public bool EditCustomer();

        public bool DeleteCustomer();

        public bool GetCustomer();

        public bool GetAllCustomers(); 
    }
}
