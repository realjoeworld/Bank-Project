using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using BankDataAccess;

namespace BankDataAccess
{
    public class clsClientDataAccess
    {
        public static DataTable GetAllClients() {

            DataTable dtClients = new DataTable("Clients");

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select * from Clients";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {

                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {

                    dtClients.Load(reader);

                }

                reader.Close();
            }

            catch (Exception)
            {
                Connection.Close();
                return null;
            }

            finally {

                Connection.Close();

            }

            return dtClients;


        }

        public static int ClientsTotalNumber() {

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select count(*) from Clients";

            SqlCommand Command = new SqlCommand(Query, Connection);

            int TotalNumber = 0;



            try {

                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    TotalNumber = Convert.ToInt32(Result);
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

        public static DataTable GettAllClients()
        {

            DataTable dtClient = new DataTable("Clients");

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select * from Clients";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {

                Connection.Open();

                SqlDataReader reader = Command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtClient.Load(reader);
                }

            }
            catch (Exception)
            {
                Connection.Close();
                return null;
            }
            finally
            {
                Connection.Close();
            }

            return dtClient;

        }

        public static bool AddNewClient(string FirstName, string LastName, string Phone, string Email, string AccountID, string Password, Int32 Balance)
        {

            bool IsAdded = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "insert into Clients values(@FirstName, @LastName, @Phone, @AccountID, @Password,@Balance, @Email)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@AccountID", AccountID);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Balance", Balance);


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
            finally {

                Connection.Close();

            }

            return IsAdded;



        }

        public static bool DoesAccountIdExist(string AccountID) {


            bool DoesExist = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select AccountID from Clients where AccountID = @AccountID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AccountID", AccountID);

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

            finally {
                Connection.Close();
            }

            return DoesExist;


        }

        public static bool UpdateClientInfo(string FirstName, string LastName, string Phone, string Email, string AccountID, string Password, Int32 Balance)
        {

            bool IsUpdated = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "Update Clients set FirstName = @FirstName, LastName = @LastName , @Phone = Phone, Email = @Email, Password = @Password, Balance = @Balance where AccountID = @AccountID;";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Balance", Balance);
            Command.Parameters.AddWithValue("@AccountID", AccountID);





            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                if (RowsAffected > 0) {
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


        public static bool Find(ref string FirstName, ref string LastName, ref string Phone, ref string Email, string AccountID, ref string Password, ref Int32 Balance)
        {

            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select * from Clients where AccountID = @AccountID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AccountID", AccountID);

            try
            {

                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    int LocalPassword = (int)Reader["Password"];

                    IsFound = true;
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];
                    Email = (string)Reader["Email"];
                    AccountID = (string)Reader["AccountID"];
                    Password = LocalPassword.ToString();
                    Balance = Convert.ToInt32(Reader["Balance"]);

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

        public static bool DeleteClient(string AccountID)
        {

            bool IsDeleted = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "delete from Clients where AccountID = @AccountID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AccountID", AccountID);

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

        public static int ClientBalance(string AccountID)
        {

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = "select Balance from Clients where AccountID = @AccountID";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("AccountID", AccountID);

            Int32 Balance = 0;

            try
            {
                Connection.Open();

                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    Balance = Convert.ToInt32(Result);
                }

            }
            catch (Exception)
            {
                Balance = 0;
            }
            finally
            {
                Connection.Close();
            }

            return Balance;

        }

        public static bool Deposit(Int32 PreviousBalance, Int32 NewBalance, short DepositValue, string AccountID, int UserID, DateTime ApplicationDate)
        {

            bool IsDeposited = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = @"Update Clients set Balance = Balance + @Amount where AccountID = @AccountID;
                            insert into Deposits
                            values(@PreviousBalance, @NewBalance, @DepositValue,@AccountID ,@UserID, @DateTime);";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Amount", DepositValue);
            Command.Parameters.AddWithValue("@AccountID", AccountID);
            Command.Parameters.AddWithValue("@PreviousBalance", PreviousBalance);
            Command.Parameters.AddWithValue("@NewBalance", NewBalance);
            Command.Parameters.AddWithValue("@DepositValue", DepositValue);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@DateTime", ApplicationDate);


            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    IsDeposited = true;
                }


            }
            catch (Exception) {
                IsDeposited = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsDeposited;

        }



        public static bool WithDraw(Int32 PreviousBalance, Int32 NewBalance, short DepositValue, string AccountID, int UserID, DateTime ApplicationDate)
        {

            bool IsDeposited = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = @"Update Clients set Balance = Balance - @Amount where AccountID = @AccountID;
                            insert into WithDraws
                            values(@PreviousBalance, @NewBalance, @DepositValue,@AccountID ,@UserID, @DateTime);";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@Amount", DepositValue);
            Command.Parameters.AddWithValue("@AccountID", AccountID);
            Command.Parameters.AddWithValue("@PreviousBalance", PreviousBalance);
            Command.Parameters.AddWithValue("@NewBalance", NewBalance);
            Command.Parameters.AddWithValue("@DepositValue", DepositValue);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@DateTime", ApplicationDate);


            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    IsDeposited = true;
                }


            }
            catch (Exception)
            {
                IsDeposited = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsDeposited;

        }

        public static bool Transfer(string AccountIDFrom, Int32 AccountIDFromNewBalance, string AccountIDTo, Int32 AccountIDToNewBalance, Int16 TransferAmount, int UserID, DateTime ApplicationTime)
        {
            
            bool IsTransfered = false;

            SqlConnection Connection = new SqlConnection(clsBankDataAccessSettings.ConnectionString);

            string Query = @"Update Clients set Balance = Balance - @TransferAmount where AccountID = @AccountIDFrom;
                             Update Clients set Balance = Balance + @TransferAmount where AccountID = @AccountIDTo;
                              insert into Transfers values(@AccountIDFrom, @AccountIDFromNewBalance, @AccountIDTo, @AccountIDToNewBalance, @TransferAmount, @UserID, @ApplicationTime )";


            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@AccountIDFrom", AccountIDFrom);
            Command.Parameters.AddWithValue("@AccountIDFromNewBalance", AccountIDFromNewBalance);
            Command.Parameters.AddWithValue("@AccountIDTo", AccountIDTo);
            Command.Parameters.AddWithValue("@AccountIDToNewBalance", AccountIDToNewBalance);
            Command.Parameters.AddWithValue("@TransferAmount", TransferAmount);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@ApplicationTime", ApplicationTime);

            try
            {
                Connection.Open();

                int RowsAffected = Command.ExecuteNonQuery();

                if (RowsAffected > 0)
                {
                    IsTransfered = true;
                }

            }
            catch (Exception)
            {
                IsTransfered = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsTransfered;


        }




    }



    }

