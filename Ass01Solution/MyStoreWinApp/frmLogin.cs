using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository userRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<MemberObject>();
            var adminEmail = adminDefaultSettings.Email;
            var adminPassword = adminDefaultSettings.Password;
            var email = txtEmail.Text;
            var password = txtPassword.Text;
            MemberObject loginAccount = userRepository.Login(email, password);
            if (email == adminEmail && password == adminPassword)
            {
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                this.Hide();
                frmMemberManagement.ShowDialog();
                this.Show();
            }
            else if (loginAccount != null)
            {
                frmUserProfile frmUserProfile = new frmUserProfile
                {
                    Text = "User Profile",
                    InsertOrUpdate = true,
                    UserProfile = loginAccount,
                    MemberRepository = userRepository,
                };
                frmUserProfile.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong email or wrong password! try again.");
            }
        }
    }
}
