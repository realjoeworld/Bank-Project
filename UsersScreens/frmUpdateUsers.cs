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
    public partial class frmUpdateUsers: Form
    {
        public frmUpdateUsers()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (clsUsers.DoesUserExist(txtboxUserNameSearch.Text))
            {

                panel3.Visible = true;
                btnUpdate.Visible = true;
                btnReset.Visible = true;
                txtboxUserName.Text = txtboxUserNameSearch.Text;


            }
            else
            {
                MessageBox.Show($"User Name '{txtboxUserNameSearch.Text}' Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panel3.Visible = false;
                btnUpdate.Visible = false;
                btnReset.Visible = false;

            }
        }

        private void txtboxPassword_Validating(object sender, CancelEventArgs e)
        {
            if(!txtboxPassword.MaskFull)
            {
                
                MessageBox.Show("Please Enter Valid Password", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtboxPassword.Clear();
                txtboxPassword.Focus();

            }
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

        private void txtboxLastName_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void txtboxPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if(!txtboxPhoneNumber.MaskFull)
            {
                MessageBox.Show("Please Enter Valid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxPhoneNumber.Clear();
                txtboxPhoneNumber.Focus();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            txtboxUserNameSearch.Clear();
            
            txtboxFirstName.Clear();
            txtboxLastName.Clear();
            txtboxPhoneNumber.Clear();
            txtboxPassword.Clear();
            
            chkboxShowClients.Checked = false;
            chckBoxAddClient.Checked = false;
            chkDeleteClient.Checked = false;
            chkUpdateClient.Checked = false;

            chkBoxShowUsers.Checked = false;
            chkBoxAddUsers.Checked = false;
            chkBoxUpdateUsers.Checked = false;
            chkBoxDeleteUsers.Checked = false;

            panel3.Visible = false;
            btnUpdate.Visible = false;
            btnReset.Visible = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
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


            if (clsUsers.UpdateUser(txtboxFirstName.Text, txtboxLastName.Text, txtboxPhoneNumber.Text, txtboxUserName.Text, txtboxPassword.Text, Permissions))
            {
                MessageBox.Show("User Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Failed To Update User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
