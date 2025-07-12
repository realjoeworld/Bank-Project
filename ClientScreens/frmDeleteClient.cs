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

namespace BankInterface1.ClientScreens
{
    public partial class frmDeleteClient: Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
        }

        clsClient Client;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!(clsClient.DoesAccountIDExist(txtboxAccountIDSearch.Text)))
            {
                
                MessageBox.Show($"Account ID {txtboxAccountIDSearch.Text} Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxAccountIDSearch.Clear();
                txtboxAccountIDSearch.Focus();
                panel3.Visible = false;
                btnDelete.Visible = false;

            }

            else
            {

                string FirstName = string.Empty;
                string LastName = string.Empty;
                string Phone = string.Empty;
                string Email = string.Empty;
              //  string AccountID = string.Empty;
                string Password = string.Empty;
                Int32 Balance = 0;

                clsClient.Find(ref FirstName, ref LastName, ref Phone, ref Email, txtboxAccountIDSearch.Text, ref Password, ref Balance);

                panel3.Visible = true;
                btnDelete.Visible = true;

                Client = new clsClient(FirstName, LastName, Phone, Email, Password, txtboxAccountIDSearch.Text, Balance);


                lblFirstName.Text = Client.FirstName;
                lblLastName.Text = Client.LastName;
                lblPhoneNumber.Text = Client.Phone;
                lblEmail.Text = Client.Email;
                lblPassword.Text = Client.Password;
                lblAccountID.Text = txtboxAccountIDSearch.Text;
                lblBalance.Text = Client.Balance.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Delete This Client? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                if (clsClient.DeleteClient(Client.AccountID))
                {
                    MessageBox.Show("Client Deleted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Error Happened", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            
            else
            {
                MessageBox.Show("Deleting Cancelled", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }



        }
    }
}
