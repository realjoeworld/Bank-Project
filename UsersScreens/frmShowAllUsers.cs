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
    public partial class frmShowAllUsers : Form
    {
        public frmShowAllUsers()
        {
            InitializeComponent();
        }

        private void frmShowAllUsers_Load(object sender, EventArgs e)
        {
        
            lblUsersTotalNumber.Text = clsUsers.GetTotalUsersNumber().ToString();
            datagridviewUsers.DataSource = clsUsers.GetAllUsers();
            
            datagridviewUsers.Columns[0].Width = 50; // ID Column Width
            datagridviewUsers.Columns[1].Width = 100; // First Name Column Width
            datagridviewUsers.Columns[2].Width = 92; // Last Name Column Width
            datagridviewUsers.Columns[3].Width = 90; // Phone Column Width
            datagridviewUsers.Columns[4].Width = 85; // UserName Column Width
            datagridviewUsers.Columns[5].Width = 75; // Password Column Width
            datagridviewUsers.Columns[6].Width = 75; // Permission Column Width

        }
    }
}
