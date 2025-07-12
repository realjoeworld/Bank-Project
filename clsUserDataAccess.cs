using System;
using System.Data;
using System.Data.SqlClient;


namespace BankDataAccess
{
    public class clsUserDataAccess
    {

        public static bool Find(ref int ID,ref string FirstName, ref string LastName,ref string Phone ,string UserName, string Password, ref int Permissions) {

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select * from Users where UserName = @UserName and Password = @Password";

            SqlCommand Command = new SqlCommand(Query,Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);

            bool IsFound = false;

            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    
                    IsFound = true;
                    
                    ID = (int)Reader["ID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];
                    Permissions = (int)Reader["Permmisions"];

                }
          
            }
            
            catch (Exception)
            {
                IsFound = false;
            }

            finally {
                Connection.Close();
            }

            return IsFound;
        
        }


        public static bool Find(ref int ID, ref string FirstName, ref string LastName, ref string Phone, string UserName,ref string Password, ref int Permissions)
        {

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select * from Users where UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);

            bool IsFound = false;

            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    IsFound = true;

                    ID = (int)Reader["ID"];
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];
                    Permissions = (int)Reader["Permmisions"];
                    Password = (string)Reader["Password"];

                }

            }

            catch (Exception)
            {
                IsFound = false;
            }

            finally
            {
                Connection.Close();
            }

            return IsFound;

        }




        public static DataTable GetAllUsers()
        {

            DataTable dtUsers = new DataTable("Users");

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select * from Users";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {

                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {

                    dtUsers.Load(reader);

                }

                reader.Close();
            }

            catch (Exception ex)
            {
                return null;
            }

            finally
            {

                Connection.Close();

            }

            return dtUsers;


        }


        public static int UsersTotalNumber()
        {

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select count(*) from Users";

            SqlCommand Command = new SqlCommand(Query, Connection);

            int TotalNumber = 0;


            try
            {

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    TotalNumber = Convert.ToInt16(Result);
                }

            }
            catch (Exception)
            {
                TotalNumber = 0;
            }
            finally
            {
                Connection.Close();
            }

            return TotalNumber;

        }

        public static bool DoesUserNameExist(string UserName)
        {


            bool DoesExist = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select UserName from Users where UserName = @UserName";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    DoesExist = true;
                }

            }

            catch (Exception)
            {
                DoesExist = false;
            }

            finally
            {
                Connection.Close();
            }

            return DoesExist;

        }

        public static bool AddNewUser(string FirstName, string LastName, string Phone, string UserName, string Password, Int32 Permissions)
        {

            bool IsAdded = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "insert into Users values(@FirstName, @LastName, @Phone, @UserName, @Password,@Permissions)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permissions", Permissions);


            try
            {

                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    IsAdded = true;
                }


            }
            catch (Exception)
            {
                IsAdded = false;
            }
            finally
            {

                Connection.Close();

            }

            return IsAdded;



        }


        public static bool UpdateUserInfo(string FirstName, string LastName, string Phone, string UserName, string Password, int Permissions)
        {

            bool IsUpdated = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "Update Users set FirstName = @FirstName, LastName = @LastName , @Phone = Phone, Password = @Password, Permmisions = @Permissions where UserName = @UserName;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permissions", Permissions);
            





            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    IsUpdated = true;
                }


            }
            catch (Exception)
            {
                IsUpdated = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsUpdated;

        }

        public static bool DeleteUser(string UserName)
        {
            bool IsDeleted = false;
            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);
            string Query = "delete from Users where UserName = @UserName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    IsDeleted = true;
                }
            }
            catch (Exception)
            {
                IsDeleted = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsDeleted;
        }


    }
}
