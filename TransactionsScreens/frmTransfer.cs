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
    public partial class frmTransfer: Form
    {
        public frmTransfer()
        {
            InitializeComponent();
        }

        clsClient ClientFrom = null;
        private void btnSearchClientFrom_Click(object sender, EventArgs e)
        {
            string FirstName = string.Empty, LastName = string.Empty, Phone = string.Empty, Email = string.Empty, Password = string.Empty;
            int Balance = 0;

            if (clsClient.Find(ref FirstName, ref LastName, ref Phone, ref Email, txtboxAccountIDSearch.Text, ref Password, ref Balance))
            {


                ClientFrom = new clsClient(FirstName, LastName, Phone, Email, Password, txtboxAccountIDSearch.Text, Balance);


                lblCurrentBalanceClientFrom.Text = ClientFrom.Balance.ToString();
                
                if(ClientFrom != null && ClientTo != null)
                {
                    panel4.Visible = true;
                    btnTransfer.Visible = true;

                }


            }

            else
            {

                ClientFrom = null;
                MessageBox.Show($"Account ID '{txtboxAccountIDSearch.Text}' does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxAccountIDSearch.Clear();
                txtboxAccountIDSearch.Focus();
                lblCurrentBalanceClientFrom.Text = "None";
                panel4.Visible = false;
                btnTransfer.Visible = false;

            }
        }

        clsClient ClientTo = null;
        private void btnSearchClientTo_Click(object sender, EventArgs e)
        {
            string FirstName = string.Empty, LastName = string.Empty, Phone = string.Empty, Email = string.Empty, Password = string.Empty;
            int Balance = 0;

            if (clsClient.Find(ref FirstName, ref LastName, ref Phone, ref Email, txtboxsearchAccountIDTo.Text, ref Password, ref Balance))
            {


                ClientTo = new clsClient(FirstName, LastName, Phone, Email, Password, txtboxsearchAccountIDTo.Text, Balance);


                lblCurrentBalanceClientTo.Text = ClientTo.Balance.ToString();

                if (ClientFrom != null && ClientTo != null)
                {
                    panel4.Visible = true;
                    btnTransfer.Visible=true;
                }


            }

            else
            {

                ClientFrom = null;
                MessageBox.Show($"Account ID '{txtboxsearchAccountIDTo.Text}' does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxsearchAccountIDTo.Clear();
                txtboxsearchAccountIDTo.Focus();
                lblCurrentBalanceClientTo.Text = "None";
                panel4.Visible = false;
                btnTransfer.Visible = false;

            }
        }

        private void txtboxWithDrawValue_Validating(object sender, CancelEventArgs e)
        {
            int Number = Convert.ToInt16(txtboxTransferValue.Text);

            if(Number > ClientFrom.Balance)
            {
                MessageBox.Show($"You can not transfer more than {ClientFrom.Balance} from {ClientFrom.AccountID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxTransferValue.Clear();
                txtboxTransferValue.Focus();
                return;
            }

            if (Number == 0) {
                MessageBox.Show("Can't Transfer 0 , Enter Another Value ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxTransferValue.Clear();
                txtboxTransferValue.Focus();
            }
        }

        private void txtboxsearchAccountIDTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            short TransferAmount = Convert.ToInt16(txtboxTransferValue.Text);

            int ClientFromNewBalance = ClientFrom.Balance - TransferAmount;

            int ClientToNewBalance = ClientTo.Balance + TransferAmount;


           
                if (MessageBox.Show($"Are You Sure You Want Transfer {txtboxTransferValue.Text} From {ClientFrom.AccountID} To {ClientTo.AccountID} ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (clsClient.Transfer(ClientFrom.AccountID, ClientFromNewBalance, ClientTo.AccountID, ClientToNewBalance, TransferAmount, clsCurrentUser.CurrentUser.ID, DateTime.Now))
                    {
                        MessageBox.Show($"Transfer {TransferAmount} From {ClientFrom.AccountID} To {ClientTo.AccountID} Done Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show($"New Balance For {ClientFrom.AccountID} is {ClientFromNewBalance}\n New Balance For {ClientTo.AccountID} is {ClientToNewBalance}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Transfer {TransferAmount} From {ClientFrom.AccountID} To {ClientTo.AccountID} Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
                else
                {
                    MessageBox.Show("Transfer Canceled", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            
            

        }
    }
}
