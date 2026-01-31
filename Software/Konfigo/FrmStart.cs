using System;
using System.Windows.Forms;
using Konfigo.Model;

namespace Konfigo
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

     

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            AppUser.Role = UserRole.Employee;
            new FrmLogin().ShowDialog();
        }

        private void btnCustomerEnter_Click(object sender, EventArgs e)
        {
            AppUser.Role = UserRole.Customer;
            AppUser.LoggedCustomer = new Customer
            {
                Id = 1,
                Name = "Test Kupac",
                Email = "kupac@email.com"
            };

            new FormCustomerOptions().ShowDialog();


        }

        private void FrmStart_Load(object sender, EventArgs e)
        {

        }
    }
}

