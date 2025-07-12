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

namespace BankInterface1
{
    public partial class frmUpdateClient: Form
    {
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!(clsClient.DoesAccountIDExist(txtboxAccountIDSearch.Text)))
            {
                
                MessageBox.Show($"Account ID {txtboxAccountIDSearch.Text} Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxAccountIDSearch.Clear();
                txtboxAccountIDSearch.Focus();
                txtboxAccountID.Clear();
                panel3.Visible = false;
                btnReset.Visible = false;
                btnUpdate.Visible = false;

            }

            else {

                panel3.Visible = true;
                btnUpdate.Visible = true;
                btnReset.Visible = true;
                txtboxAccountID.Text = txtboxAccountIDSearch.Text;

            }

        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
           
        }

        private void txtboxPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if(!txtboxPhoneNumber.MaskFull) {

                MessageBox.Show("Please Enter Valid Number");
                txtboxPhoneNumber.Clear();
                txtboxPhoneNumber.Focus();
            
            }
        }

        private void txtboxLastName_Validating(object sender, CancelEventArgs e)
        {
            if(txtboxLastName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Valid LastName","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtboxFirstName_Validating(object sender, CancelEventArgs e)
        {
            if( txtboxFirstName.Text == string.Empty)
              MessageBox.Show("Please Enter Valid FirstName", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtboxBalance_Validating(object sender, CancelEventArgs e)
        {
            if(txtboxBalance.MaskFull)
            {

                MessageBox.Show("Please Enter Valid Balance", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void txtboxPassword_Validating(object sender, CancelEventArgs e)
        {
          
            if(!txtboxPassword.MaskFull)
            {
                MessageBox.Show("Please Enter Valid Password" , "" , MessageBoxButtons.OK , MessageBoxIcon.Error);

            }
        
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(clsClient.UpdateClient(txtboxFirstName.Text,txtboxLastName.Text,txtboxPhoneNumber.Text,txtboxEmail.Text,txtboxAccountID.Text,txtboxPassword.Text,Convert.ToInt32(txtboxBalance.Text)))
            {

                MessageBox.Show("Client Updated Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {
                MessageBox.Show("Error Happened", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxFirstName.Clear();
            txtboxLastName.Clear();
            txtboxPhoneNumber.Clear();
            txtboxEmail.Clear();
            txtboxAccountID.Clear();
            txtboxPassword.Clear();
            txtboxBalance.Clear();

            txtboxFirstName.Focus();
        }
    }
}
