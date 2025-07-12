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

namespace BankInterface1.TransactionsScreens
{
    public partial class frmDeposit: Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

        clsClient Client;

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string FirstName = string.Empty, LastName = string.Empty, Phone = string.Empty, Email = string.Empty, Password = string.Empty;
            int Balance = 0;

            if (clsClient.Find(ref FirstName, ref LastName, ref Phone, ref Email, txtboxAccountIDSearch.Text, ref Password, ref Balance))
            {
                

                Client = new clsClient(FirstName, LastName, Phone, Email, Password, txtboxAccountIDSearch.Text, Balance);

               
                lblCurrentBalance.Text = clsClient.ClientBalance(txtboxAccountIDSearch.Text).ToString();
                panel4.Visible = true;
                btnDeposit.Visible = true;


            }

            else
            {
                
                Client = null;
                MessageBox.Show($"Account ID '{txtboxAccountIDSearch.Text}' does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxAccountIDSearch.Clear();
                txtboxAccountIDSearch.Focus();
                lblCurrentBalance.Text = "None";

            }





        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            Int32 NewBalance = Client.Balance +Convert.ToInt16(txtboxDepositValue.Text);

            if (MessageBox.Show($"Are You Sure Want To Deposit {txtboxDepositValue.Text} Into {txtboxAccountIDSearch.Text} ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsClient.Deposit(Client.Balance, NewBalance, Convert.ToInt16(txtboxDepositValue.Text), Client.AccountID, clsCurrentUser.CurrentUser.ID, DateTime.Now))
                {
                    MessageBox.Show($"Deposit of {txtboxDepositValue.Text} into {Client.AccountID} was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"New Balance is {Client.Balance + Convert.ToInt16(txtboxDepositValue.Text)}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Deposit failed, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtboxDepositValue_Validating(object sender, CancelEventArgs e)
        {
            int Number = Convert.ToInt16(txtboxDepositValue.Text);
            if(Number == 0) {
                MessageBox.Show("Please Enter Any Number Other Than 0 ");
                txtboxDepositValue.Clear();
                txtboxDepositValue.Focus();
                return;
            }

            
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {

        }
    }
}
