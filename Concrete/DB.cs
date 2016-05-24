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
        bool InserCustomer();

        bool EditCustomer();

        bool DeleteCustomer();

        bool GetCustomer();

        bool GetAllCustomers();
    }
}