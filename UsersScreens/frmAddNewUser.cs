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
    public partial class frmAddNewUser: Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxFirstName.Clear();
            txtboxLastName.Clear();
            txtboxPhoneNumber.Clear();
            txtboxUserName.Clear();
            txtboxPassword.Clear();

            chkboxShowClients.Checked = false;
            chckBoxAddClient.Checked = false;
            chkDeleteClient.Checked = false;
            chkUpdateClient.Checked = false;

            chkBoxShowUsers.Checked = false;
            chkBoxAddUsers.Checked = false;
            chkBoxUpdateUsers.Checked = false;
            chkBoxDeleteUsers.Checked=false;

        }

        private void txtboxUserName_Validating(object sender, CancelEventArgs e)
        {
            if (txtboxUserName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid User Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxUserName.Clear();
                txtboxUserName.Focus();
                return;
            }

            if (clsUsers.DoesUserExist(txtboxUserName.Text))
            {
                MessageBox.Show($"User Name '{txtboxUserName.Text}' Already Exists, Choose Another One", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxUserName.Clear();
                txtboxUserName.Focus();
            }

        }

        private void txtboxUserName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtboxFirstName_Validating(object sender, CancelEventArgs e)
        {

            if(txtboxFirstName.Text == string.Empty)
            {

                MessageBox.Show("Please Enter Valid First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxFirstName.Clear();
                txtboxFirstName.Focus();
            }

        }

        private void txtboxLastName_Validating(object sender, CancelEventArgs e)
        {


            if (txtboxLastName.Text == string.Empty)
            {

                MessageBox.Show("Please Enter Valid Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxLastName.Clear();
                txtboxLastName.Focus();
            }

        }

        private void txtboxPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!txtboxPhoneNumber.MaskFull)
            {

                MessageBox.Show("Please Enter Valid Phone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxPhoneNumber.Clear();
                txtboxPhoneNumber.Focus();

            }

        }

        private void txtboxPassword_Validating(object sender, CancelEventArgs e)
        {

            if(txtboxPassword.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxPassword.Clear();
                txtboxPassword.Focus();
            }

        }

        private void btnLAddUser_Click(object sender, EventArgs e)
        {
            int Permissions = 0;

            if (chkboxShowClients.Checked)
            {
                Permissions += 1;
            }

            if (chckBoxAddClient.Checked)
            {
                Permissions += 2;
            }

            if (chkUpdateClient.Checked)
            {
                Permissions += 4;
            }

            if (chkDeleteClient.Checked)
            {
                Permissions += 8;
            }

            if (chkBoxShowUsers.Checked)
            {
                Permissions += 16;
            }

            if (chkBoxAddUsers.Checked)
            {
                Permissions += 32;
            }

            if (chkBoxUpdateUsers.Checked)
            {
                Permissions += 64;
            }

            if (chkBoxDeleteUsers.Checked)
            {
                Permissions += 128;
            }

            if (Permissions == 0)
            {
                Permissions = 1;
            }

            clsUsers NewUser = new clsUsers(txtboxFirstName.Text, txtboxLastName.Text, txtboxPhoneNumber.Text, txtboxUserName.Text, txtboxPassword.Text, Permissions);

            if (clsUsers.AddNewUser(NewUser.FirstName, NewUser.LastName, NewUser.Phone, NewUser.UserName, NewUser.Password, NewUser.Permission))
            {
                MessageBox.Show("New User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            else
            {
                MessageBox.Show("Failed To Add New User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
