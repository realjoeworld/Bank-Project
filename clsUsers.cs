using System;
using BankDataAccess;
using System.Data;



namespace BankBussnis
{
    public class clsUsers
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }

        public int Permission { get; set; }


        public clsUsers(int ID, string FirstName, string LastName, string Phone, string UserName, string Password, int Permission)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;
        }

        public clsUsers(string FirstName, string LastName, string Phone, string UserName, string Password, int Permission)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.UserName = UserName;
            this.Password = Password;
            this.Permission = Permission;
        }



        public static bool Find(ref int ID,ref string FirstName,ref string LastName,ref string Phone,string UserName, string Password, ref int Permissions)
        {
            return clsUserDataAccess.Find(ref ID,ref FirstName,ref LastName,ref Phone,UserName, Password, ref Permissions);
        }

        public static bool Find(ref int ID, ref string FirstName, ref string LastName, ref string Phone, string UserName,ref string Password, ref int Permissions)
        {
            return clsUserDataAccess.Find(ref ID, ref FirstName, ref LastName, ref Phone, UserName,ref Password, ref Permissions);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static int GetTotalUsersNumber()
        {

            return clsUserDataAccess.UsersTotalNumber();
        }

        public static bool DoesUserExist(string UserName)
        {
            return clsUserDataAccess.DoesUserNameExist(UserName);
        }

        public static bool AddNewUser(string FirstName, string LastName, string Phone, string UserName, string Password, Int32 Permissions)
        {
            return clsUserDataAccess.AddNewUser(FirstName, LastName, Phone, UserName, Password, Permissions);
        }

        public static bool UpdateUser(string FirstName,string LastName, string Phone,string UserName, string Password, int Permissions) { 
            return clsUserDataAccess.UpdateUserInfo(FirstName, LastName, Phone, UserName, Password, Permissions);
        }

        public static bool DeleteUser(string UserName)
        {
            return clsUserDataAccess.DeleteUser(UserName);
        }




    }
}
