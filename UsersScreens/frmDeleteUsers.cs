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

namespace BankInterface1.UsersScreens
{
    public partial class frmDeleteUsers : Form
    {
        public frmDeleteUsers()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!(clsUsers.DoesUserExist(txtboxUserNameSearch.Text)))
            {

                MessageBox.Show($"UserName: {txtboxUserNameSearch.Text} Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxUserNameSearch.Clear();
                txtboxUserNameSearch.Focus();
                panel3.Visible = false;
                btnDelete.Visible = false;

            }
            else
            {

                int ID = 0;
                string FirstName = string.Empty;
                string LastName = string.Empty;
                string Phone = string.Empty;
                string UserName = string.Empty;
                //  string AccountID = string.Empty;
                string Password = string.Empty;
                int Permissions = 0;

                clsUsers.Find(ref ID, ref FirstName, ref LastName, ref Phone, txtboxUserNameSearch.Text, ref Password, ref Permissions);

                panel3.Visible = true;
                btnDelete.Visible = true;


                clsUsers UserToDelete = new clsUsers(FirstName, LastName, Phone, txtboxUserNameSearch.Text, Password, Permissions);

                lblFirstName.Text = UserToDelete.FirstName;
                lblLastName.Text = UserToDelete.LastName;
                lblPhoneNumber.Text = UserToDelete.Phone;
                lblUserName.Text = UserToDelete.UserName;
                lblPassword.Text = UserToDelete.Password;
                lblPermissions.Text = UserToDelete.Permission.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure Do Want To Delete This User ? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsUsers.DeleteUser(txtboxUserNameSearch.Text))
                {
                    MessageBox.Show("User Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed To Delete User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("User Not Deleted", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
