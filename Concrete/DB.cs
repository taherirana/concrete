using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class DB : IDatabase
    {
        private SqlCommand cmd = new SqlCommand();
        private SqlConnection con = new SqlConnection();
        private SqlDataAdapter da = new SqlDataAdapter();

        public DB()
        {
            con.ConnectionString = "server=(local);database=concreteBB; Integrated Security=SSPI";
            cmd.Connection = con;
            
        }






        public bool InserCustomer(Customer c)
        {
            cmd.CommandText = "INSERT INTO Customer (Customer_Name,Customer_Family,Customer_ID_code) values (@FirstName , @LastName , @IDCode)";
            cmd.Parameters.Add("@FirstName", c.Firstname);
            cmd.Parameters.Add("@LastName", c.LastName);
            cmd.Parameters.Add("@IDCode", c.IDCode);

            Open();

            int count = cmd.ExecuteNonQuery();

            Close();
            
            if (count > 0)
                return true;

            return false;
        }

        public bool EditCustomer(Customer c)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Customer c)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            con.Open();
        }

        public void Close()
        {
            con.Close();
        }
    }

    public interface IDatabase
    {
        bool InserCustomer(Customer c);

        bool EditCustomer(Customer c);

        bool DeleteCustomer(Customer c);

        Customer GetCustomer();

        List<Customer> GetAllCustomers();

        void Open();

        void Close();
    }
}