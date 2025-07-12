using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BankBussnis;


namespace BankInterface1
{
    public partial class frmAddNewClient: Form
    {
        public frmAddNewClient()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
         
            if (!(IsValidEmail(txtboxEmail.Text))) {
                MessageBox.Show("Please Enter Valid Email");
                txtboxEmail.Clear();
                txtboxEmail.Focus();
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLAddClinet_Click(object sender, EventArgs e)
        {

            txtboxPhoneNumber.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string phone = txtboxPhoneNumber.Text;


            if (clsClient.AddNewClient(txtboxFirstName.Text, txtboxLastName.Text, phone, txtboxEmail.Text, txtboxAccountID.Text,txtboxPassword.Text ,Convert.ToInt32(txtboxBalance.Text)))
            {
                MessageBox.Show("Client Added Successfully");
                //this.Close();
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error Adding Client");

            }
        
        }


        private void textBox4_Validating(object sender, CancelEventArgs e)
        {

            if(txtboxAccountID.Text == string.Empty) {
                
                MessageBox.Show($"Please Enter Account ID");
                txtboxAccountID.Focus();

            }

            if (clsClient.DoesAccountIDExist(txtboxAccountID.Text))
            {
                MessageBox.Show($"Account ID '{txtboxAccountID.Text}' Already Used");
                txtboxAccountID.Clear();
                txtboxAccountID.Focus();

            }
          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxFirstName.Clear();
            txtboxLastName.Clear();
            txtboxEmail.Clear();
            txtboxAccountID.Clear();
            txtboxPhoneNumber.Clear();
            txtboxBalance.Clear();
            txtboxPassword.Clear();

            txtboxFirstName.Focus();

        }

        private void txtboxPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!txtboxPhoneNumber.MaskFull)
            {
                MessageBox.Show("Please enter a valid phone number.");
                txtboxPhoneNumber.Clear();
                txtboxPhoneNumber.Focus();
            }
        }
    }

}
