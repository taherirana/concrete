using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Concrete
{
    public class DB : IDatabase
    {
        int i = 12;
        int f = 100;

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
            int count = -1;

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
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }


        public bool InsertConcrete(Concrete ce)
        {
            cmd.CommandText = "INSERT INTO Concrete_Type (Concrete_Type_Code , Concrete_Price)  VALUES (@Concrete_Type_Code , @Concrete_Price)";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@Concrete_Type_Code", ce.Type.ToString());
            cmd.Parameters.AddWithValue("@Concrete_Price", ce.Price.ToString());

            try
            {
                Open();

                int count = cmd.ExecuteNonQuery();

                if (count > 0)
                    return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            finally
            {
                Close();

            }

            return false;

        }

        public bool InsertCareer(Career cr)
        {

            int CareerOwnerShipID = GetCareerOwnerShipTypeID(cr.ownership);


            cmd.CommandText = "INSERT INTO Career (CareerDriverName , CareerDriverFamily , CareerNumber ,FK_Career_OwnerShip_type )  VALUES (@CareerDriverName , @CareerDriverFamily,@CareerNumber,@FK_Career_OwnerShip_type)";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@CareerDriverName", cr.CareerDriverFName);
            cmd.Parameters.AddWithValue("@CareerDriverFamily", cr.CareerDriverLName);
            cmd.Parameters.AddWithValue("@CareerNumber", cr.plaque);
            cmd.Parameters.AddWithValue("@FK_Career_OwnerShip_type", CareerOwnerShipID);



            if (CareerOwnerShipID > 0)
            {

                try
                {
                    Open();

                    int count = cmd.ExecuteNonQuery();

                    if (count > 0)
                        return true;

                }
                catch (Exception)
                {
                    return false;
                }
                finally
                {
                    Close();
                }

            }
            return false;
        }


        public int GetCareerOwnerShipTypeID(string OwnerShipTypeName)
        {
            cmd.CommandText = "select * from  Owner_Type ";//where Owner_Type = @OwnerShipTypeName";
            cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@OwnerShipTypeName", OwnerShipTypeName);
            //List<CareerOwnerShipType> ownerShips = new List<CareerOwnerShipType>();

            int ID = -1;
            try
            {
                Open();

                var result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        CareerOwnerShipType cro = new CareerOwnerShipType(int.Parse(result.GetValue(0).ToString()), result.GetValue(1).ToString());
                       // ownerShips.Add(cro);

                        if (OwnerShipTypeName == cro.OwnerShipName)
                            return cro.ID;
                    }
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                Close();
            }
            return ID;
        }

        public List<string> getAllownerShiptype()
        {
            cmd.CommandText = "select * from  Owner_Type";
            cmd.Parameters.Clear();

            List<string> ownerShips = new List<string>();

            try
            {
                Open();

                var result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        //CareerOwnerShipType cro = new CareerOwnerShipType ( int.Parse( result.GetValue(0).ToString()), result.GetValue(1).ToString() );
                        ownerShips.Add(result.GetValue(1).ToString());
                    }
                }
            }
            catch (Exception)
            {  
            }

            return ownerShips;
        }


        public List<Customer> GetCustomersIDByCodeID(string CodeID)
        {
            cmd.CommandText = string.Format("select * from Customer where Customer_ID_code = '{0}'", CodeID);
            
            List<Customer> Customers = new List<Customer>();

            try
            {
                Open();

                var result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    while (result.Read())
                    {

                        string Fname = result.GetValue(1).ToString();
                        string Lname = result.GetValue(2).ToString();
                        string IDCode = result.GetValue(3).ToString();

                        Customer c = new Customer(Fname,Lname,IDCode);
                        c.CustomerID = int.Parse(result.GetValue(0).ToString());
                        Customers.Add(c);
                        
                    }
                }
            }
            catch (Exception)
            {


            }
            finally
            {
                Close();
            }
            return Customers;

        }

        public List<Career> getCareersbyPlaque(string _Plaque)
        {
            cmd.CommandText = string.Format("select * from Career where CareerNumber like '%{0}%'", _Plaque);

            List<Career> careers = new List<Career>();

            try
            {
                Open();

                var results = cmd.ExecuteReader();

                if (results.HasRows)
                {
                    while (results.Read())
                    {
                        string FName  = results.GetValue(1).ToString();
                        string LName  = results.GetValue(2).ToString();    
                        string Plaque = results.GetValue(3).ToString();
                        string ownerShip = results.GetValue(4).ToString();

                        Career c = new Career(FName, LName, Plaque, ownerShip);
                        c.CareerID = results.GetValue(0).ToString();
                        
                        careers.Add(c);

                    }
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                Close();
            }

            return careers;
        }

        public bool ConcreteOrder(ConcreteSellOrder cso)
        {
            SqlTransaction tr = null;


            cmd.CommandText = "INSERT INTO Concrete_Order (Total_Price , Total_Weight , FK_User_ID , FK_Customer_ID) OUTPUT INSERTED.OrderID  VALUES(@Total_Price , @Total_Weight , @FK_User_ID , @FK_Customer_ID)";
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@Total_Price" , cso.Sum(c=>c.price));
            cmd.Parameters.AddWithValue("@Total_Weight", cso.Sum(c => c.WeightInM2));
            cmd.Parameters.AddWithValue("@FK_User_ID", Util.user.ID);
            cmd.Parameters.AddWithValue("@FK_Customer_ID", cso.customer.CustomerID);

            try
            {
                Open();
                tr = con.BeginTransaction("Concrete Order tr");
                cmd.Transaction = tr;
                int OrderID = int .Parse(cmd.ExecuteScalar().ToString());


                if(InsetCocereteOrderDetail(cso,OrderID))
                    tr.Commit();
            }
            catch (Exception ex)
            {
                tr.Rollback();
                return false;
            }
            finally
            {
                Close();
                
            }
            
            return true;
        }

        public bool InsetCocereteOrderDetail(ConcreteSellOrder cso , int OrderID)
        {
            cmd.CommandText = @"INSERT INTO Concrete_Order_Detail ([FK_Order_ID] ,[FK_Mixer_ID],[FK_Career] ,[FK_Concrete_Type_Code] ,[Weight] ,[FK_Customer_AddressID] ,[Date] ,[Concrete_Price]) 
                                                            VALUES(@FK_Order_ID, @FK_Mixer_ID , @FK_Career , @FK_Concrete_Type_Code , @Weight , @FK_Customer_AddressID , @Date , @Concrete_Price)";

            for (int i = 0; i < cso.Count; i++)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FK_Order_ID", OrderID);
                cmd.Parameters.AddWithValue("@FK_Mixer_ID", DBNull.Value/*cso.Items[i].MixerID*/);
                cmd.Parameters.AddWithValue("@FK_Career", cso.Items[i].CareerID);   
                cmd.Parameters.AddWithValue("@FK_Concrete_Type_Code", int.Parse(cso.Items[i].ConcreteType));
                cmd.Parameters.AddWithValue("@Weight", int.Parse(cso.Items[i].WeightInM2.ToString()));
                cmd.Parameters.AddWithValue("@FK_Customer_AddressID", DBNull.Value);
                cmd.Parameters.AddWithValue("@Date", "");
                cmd.Parameters.AddWithValue("@Concrete_Price", cso.Items[i].price);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        public List<Concrete> getConccretesType()
        {
            List<Concrete> c = new List<Concrete>();
            
            cmd.CommandText = "SELECT * FROM Concrete_Type";

            try
            {
                Open();
                var result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        c.Add(new Concrete(int.Parse( result.GetValue(0).ToString()), int.Parse( result.GetValue(1).ToString())));
    }
                }
        
            }
            catch
            {
                return null;
            }
            finally
            {
                Close();
            }

            return c;
        }

        public List<string> getAllConcreteOperation()
        {
            cmd.CommandText = "SELECT * FROM Concrete_Operation";
            List<string> co = new List<string>();

            try
            {
                Open();

                var result = cmd.ExecuteReader();

                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        co.Add(result.GetValue(0).ToString());
                    }
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                Close();
            }
            return co;
        }
    }
        
    public interface IDatabase
    {

        bool InserCustomer(Customer c);

        bool EditCustomer(Customer c);

        bool DeleteCustomer(Customer c);

        Customer GetCustomer();

        List<Customer> GetAllCustomers();

        bool InsertConcrete(Concrete ce);

        bool InsertCareer(Career cr);

        int GetCareerOwnerShipTypeID(string OwnerShipTypeName);

        List<string> getAllownerShiptype();

        bool ConcreteOrder(ConcreteSellOrder cso);

        List<Concrete> getConccretesType();

        List<string> getAllConcreteOperation();

        void Open();

        void Close();

    }
}