using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Konfigo.Repository;


using Konfigo.Model;


namespace Konfigo
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            var teacher = TeacherRepository.GetTeacher(username);

            if (teacher != null && teacher.CheckPassword(password))
            {
                AppUser.LoggedTeacher = teacher;
                AppUser.Role = UserRole.Employee;
                AppUser.LoggedEmployee = new Employee
                {
                    Id = teacher.Id,
                    Username = teacher.Username,
                    Password = teacher.Password
                };

                Hide();
                var componentsForm = new FormComponents();
                componentsForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Neispravni podaci.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
