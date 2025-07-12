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
    public partial class frmWithdraw : Form
    {
        public frmWithdraw()
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
                btnWithDraw.Visible = true;



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

        private void txtboxWithDrawValue_Validating(object sender, CancelEventArgs e)
        {

            int Number = Convert.ToInt16(txtboxWithDrawValue.Text);
            
            if (Number == 0)
            {
                MessageBox.Show("Please Enter Any Number Other Than 0 ");
                txtboxWithDrawValue.Clear();
                txtboxWithDrawValue.Focus();
                return;
            }

            if (Convert.ToInt16(txtboxWithDrawValue.Text) > Client.Balance)
            {

                MessageBox.Show("Withdraw value cannot be greater than current balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxWithDrawValue.Clear();
                txtboxWithDrawValue.Focus();
                return;

            }
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            Int32 NewBalance = Client.Balance - Convert.ToInt16(txtboxWithDrawValue.Text);

            if (MessageBox.Show($"Are You Sure Want To WithDraw {txtboxWithDrawValue.Text} From {txtboxAccountIDSearch.Text} ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsClient.WithDraw(Client.Balance, NewBalance, Convert.ToInt16(txtboxWithDrawValue.Text), Client.AccountID, clsCurrentUser.CurrentUser.ID, DateTime.Now))
                {
                    MessageBox.Show($"WithDraw of {txtboxWithDrawValue.Text} From {Client.AccountID} was successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show($"New Balance is {Client.Balance - Convert.ToInt16(txtboxWithDrawValue.Text)}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("WithDraw failed, please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    
    
    
    
    }
}
