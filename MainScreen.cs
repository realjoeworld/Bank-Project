using BankInterface1.ClientScreens;
using BankInterface1.TransactionsScreens;
using BankInterface1.UsersScreens;
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
    public partial class MainScreen: Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmShowAllUsers ShowAllUsersScreen = new frmShowAllUsers();

            ShowAllUsersScreen.ShowDialog();

        }

        private void showAllClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmShowAllClients ShowAllClients = new frmShowAllClients();

            ShowAllClients.ShowDialog();

        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmAddNewClient AddNewClientForm = new frmAddNewClient();

            AddNewClientForm.ShowDialog();

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUpdateClient UpdateClientForm = new frmUpdateClient();

            UpdateClientForm.ShowDialog();

        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmDeleteClient DeleteClientForm = new frmDeleteClient();

            DeleteClientForm.ShowDialog();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAddNewUser AddNewUserForm = new frmAddNewUser();

            AddNewUserForm.ShowDialog();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {


            frmUpdateUsers UpdateUsersForm = new frmUpdateUsers();

            UpdateUsersForm.ShowDialog();


        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
            frmDeleteUsers DeleteUsersForm = new frmDeleteUsers();

            DeleteUsersForm.ShowDialog();

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

            frmDeposit DepositForm = new frmDeposit();

            DepositForm.ShowDialog();

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmWithdraw WithDrawForm = new frmWithdraw();

            WithDrawForm.ShowDialog();

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmTransfer TransferForm = new frmTransfer();

            TransferForm.ShowDialog();

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            

        }
    }
}
