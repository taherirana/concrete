﻿using System;
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

            if (InsertCustomerBasicInfo(c))
            {
                if (insertCustomerPhones(c))
                {
                    if (insertCustomerAddress(c))
                    {
                        transaction.Commit();
                        Close();
                        return true;
                    }
                }
            }
            transaction.Rollback();
            Close();
            return false;
            
        }


        private bool InsertCustomerBasicInfo(Customer c)
        {
            cmd.CommandText = "INSERT INTO Customer (Customer_Name,Customer_Family,Customer_ID_code) OUTPUT INSERTED.Customer_ID values (@FirstName , @LastName , @IDCode)";
            cmd.Parameters.AddWithValue("@FirstName", c.Firstname);
            cmd.Parameters.AddWithValue("@LastName", c.LastName);
            cmd.Parameters.AddWithValue("@IDCode", c.IDCode);

            try
            {
                c.CustomerID = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public bool insertCustomerPhones(Customer c)
        {
            cmd.CommandText = "INSERT INTO Customer_Phone (FK_Customer_ID,PhoneNumber) OUTPUT INSERTED.FK_Customer_ID values ( @FK_Customer_ID , @PhoneNumber)";
            cmd.Parameters.Clear();
            int count=-1;
            
            try
            {
                Open();

                foreach (string phone in c.Phones)
                {
                    cmd.Parameters.AddWithValue("@FK_Customer_ID", c.CustomerID);
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

        public bool insertCustomerAddress(Customer c)
        {
            cmd.CommandText = "INSERT INTO Customer_Address (FK_Customer_ID,Address) OUTPUT INSERTED.FK_Customer_ID values ( @FK_Customer_ID , @Address)";
            cmd.Parameters.Clear();

            int count = -1;

            try
            {
                Open();

                foreach (string address in c.Addresses)
                {
                    cmd.Parameters.AddWithValue("@FK_Customer_ID", c.CustomerID);
                    cmd.Parameters.AddWithValue("@Address", address);

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