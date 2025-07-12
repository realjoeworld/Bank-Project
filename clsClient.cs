using System;
using BankDataAccess;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace BankBussnis
{
    public class clsClient
    {

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string AccountID { get; set; }

        public string Password { get; set; }

        public int Balance { get; set; }

        public clsClient(string FirstName, string LastName, string Phone, string Email, string Passsword, string AccountID, int Balance)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.AccountID = AccountID;
            this.Password = Passsword;
            this.Balance = Balance;

        }


        public static DataTable GetAllClients()
        {

            return clsClientDataAccess.GetAllClients();

        }
        public static int ClientsTotalNumber()
        {
            return clsClientDataAccess.ClientsTotalNumber();
        }



        public static bool AddNewClient(string FirstName, string LastName, string Phone, string Email, string AccountID, string Passsword, Int32 Balance)
        {
            return clsClientDataAccess.AddNewClient(FirstName, LastName, Phone, Email, AccountID, Passsword, Balance);

        }
        public static bool DoesAccountIDExist(string AccountID)
        {
            return clsClientDataAccess.DoesAccountIdExist(AccountID);
        }

        public static bool UpdateClient(string FirstName, string LastName, string Phone, string Email, string AccountID, string Password, Int32 Balance)
        {
            return clsClientDataAccess.UpdateClientInfo(FirstName, LastName, Phone, Email, AccountID, Password, Balance);
        }

        public static bool Find(ref string FirstName, ref string LastName, ref string Phone, ref string Email, string AccountID, ref string Password, ref Int32 Balance)
        {
            return clsClientDataAccess.Find(ref FirstName, ref LastName, ref Phone, ref Email, AccountID, ref Password, ref Balance);
        }

        public static bool DeleteClient(string AccountID)
        {
            return clsClientDataAccess.DeleteClient(AccountID);
        }

        public static int ClientBalance(string AccountID)
        {
            return clsClientDataAccess.ClientBalance(AccountID);
        }

        public static bool Deposit(Int32 PreviousBalance, Int32 NewBalance, short DepositValue, string AccountID, int UserID, DateTime ApplicationDate)
        {
            return clsClientDataAccess.Deposit(PreviousBalance, NewBalance, DepositValue, AccountID, UserID, ApplicationDate);
        }

        public static bool WithDraw(Int32 PreviousBalance, Int32 NewBalance, short WithdrawValue, string AccountID, int UserID, DateTime ApplicationDate)
        {
            return clsClientDataAccess.WithDraw(PreviousBalance, NewBalance, WithdrawValue, AccountID, UserID, ApplicationDate);
        }

        public static bool Transfer(string AccountIDFrom, Int32 AccountIDFromNewBalance, string AccountIDTo, Int32 AccountIDToNewBalance, Int16 TransferAmount, int UserID, DateTime ApplicationTime)
        {
            return clsClientDataAccess.Transfer(AccountIDFrom, AccountIDFromNewBalance, AccountIDTo, AccountIDToNewBalance, TransferAmount, UserID, ApplicationTime);

        }
    
    
    
    
    
    }
}