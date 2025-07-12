using BankBussnis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BankBussnis;

namespace BankInterface1
{
    public partial class LoginScreen: Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void lblClearFields_Click(object sender, EventArgs e)
        {
            txtboxUserName.Clear();
            txtboxPassword.Clear();
            txtboxUserName.Focus();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Exit ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int ID = 0;
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string Phone = string.Empty;
            int Permissions = 0;

            if (clsUsers.Find(ref ID, ref FirstName, ref LastName, ref Phone, txtboxUserName.Text, txtboxPassword.Text, ref Permissions))
            {

                clsCurrentUser.CurrentUser = new clsUsers(ID, FirstName, LastName, Phone, txtboxUserName.Text, txtboxUserName.Text, Permissions);

                // MessageBox.Show("Welcome " + clsCurrentUser.CurrentUser.FirstName + " " + clsCurrentUser.CurrentUser.LastName, "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                MainScreen mainScreen = new MainScreen();

                mainScreen.Show();

            }
            else {
            MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
