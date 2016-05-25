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
            con.ConnectionString = "server=(local);database=concreteBB;Integrated Security=True";
            cmd.Connection = con;
        }



        public bool InserCustomer(Customer c)
        {
            Open();

            SqlTransaction transaction = null;
            transaction = con.BeginTransaction("Insert phones Transaction");
            cmd.Transaction = transaction;


            int id = InsertCustomerBasicInfo(c);
            if (id > 0)
            {
                if (insertCustomerPhones(c, id))
                    if (insertCustomerAddress(c, id))
                    {
                        transaction.Commit();
                        Close();
                        return true;
                    }
                        
            }

            transaction.Rollback();
            Close();
            return false;
            
        }


        private int InsertCustomerBasicInfo(Customer c)
        {
            cmd.CommandText = "INSERT INTO Customer (Customer_Name,Customer_Family,Customer_ID_code) OUTPUT INSERTED.Customer_ID values (@FirstName , @LastName , @IDCode)";
            cmd.Parameters.AddWithValue("@FirstName", c.Firstname);
            cmd.Parameters.AddWithValue("@LastName", c.LastName);
            cmd.Parameters.AddWithValue("@IDCode", c.IDCode);

            int id = -1;

            try
            {
               

                id = int.Parse( cmd.ExecuteScalar().ToString() );
                insertCustomerPhones(c, id);
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                
            }

            return id;
        }

        public bool insertCustomerPhones(Customer c , int CustomerID)
        {
            cmd.CommandText = "INSERT INTO Customer_Phone (FK_Customer_ID,PhoneNumber) OUTPUT INSERTED.FK_Customer_ID values ( @FK_Customer_ID , @PhoneNumber)";

            int count=-1;
            
            try
            {
                Open();

                foreach (string phone in c.Phones)
                {
                    cmd.Parameters.AddWithValue("@FK_Customer_ID", CustomerID);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phone);
                    
                    count = int.Parse(cmd.ExecuteScalar().ToString());

                    if (count < 0)
                        return false;

                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool insertCustomerAddress(Customer c, int CustomerID)
        {
            cmd.CommandText = "INSERT INTO Customer_Phone (FK_Customer_ID,PhoneNumber) OUTPUT INSERTED.FK_Customer_ID values ( @FK_Customer_ID , @Address)";

            SqlTransaction transaction = null;

            int count = -1;

            try
            {
                Open();

                transaction = con.BeginTransaction("Insert phones Transaction");

                cmd.Transaction = transaction;

                foreach (string address in c.Addresses)
                {
                    cmd.Parameters.AddWithValue("@FK_Customer_ID", CustomerID);
                    cmd.Parameters.AddWithValue("@PhoneNumber", address);

                    count = int.Parse(cmd.ExecuteScalar().ToString());

                    if (count < 0)
                        return false;

                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
            }

            transaction.Commit();
            Close();

            return true;
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

        private int getCustomerID(string _Firstname, String _LastName)
        {
            cmd.CommandText = string.Format("select Customer_ID from Customer where Customer_Name = '{0}' and Customer_Family = '{1}'", _Firstname, _LastName);
            int id=-1;
            try
            {
                Open();
                id = int.Parse( cmd.ExecuteScalar().ToString());
            }
            catch
            {

            }
            finally
            {
                Close();
            }

            return id;
        }

        /// <summary>
        /// get Customer By ID_Code
        /// </summary>
        /// <param name="Customer_ID_code"></param>
        /// <returns></returns>
        private int getCustomerID(string Customer_ID_code)
        {
            cmd.CommandText = string.Format("select Customer_ID from Customer where Customer_ID_code = '{0}'", Customer_ID_code);
            int id = -1;
            try
            {
                Open();
                id = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            {

            }
            finally
            {
                Close();
            }

            return id;
        }

        public void Open()
        {
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();
        }

        public void Close()
        {
            if(con.State ==System.Data.ConnectionState.Open)
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