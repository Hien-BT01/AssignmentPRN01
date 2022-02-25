using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmUserProfile : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; } //False : Insert, True : Update
        public MemberObject UserProfile { get; set; }
        public frmUserProfile()
        {
            InitializeComponent();
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            txtUserID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtUserID.Text = UserProfile.MemberID;
                txtUserEmail.Text = UserProfile.Email;
                txtUserPassword.Text = UserProfile.Password;
                txtUserName.Text = UserProfile.MemberName;
                txtUserCity.Text = UserProfile.City;
                txtUserCountry.Text = UserProfile.Country;
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new MemberObject
                {
                    MemberID = txtUserID.Text,
                    Email = txtUserEmail.Text,
                    Password = txtUserPassword.Text,
                    MemberName = txtUserName.Text,
                    City = txtUserCity.Text,
                    Country = txtUserCountry.Text,
                };
                if(InsertOrUpdate == false)
                {
                    MemberRepository.InsertNewUser(user);
                    MessageBox.Show("Add new user successfully");
                    Close();
                }
                else
                {
                    MemberRepository.UpdateUser(user);
                    MessageBox.Show("Update user successfully");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Error at Adding new User" : "Error at Updating new User");
                Close();
            }
        }

        private void btnCloseProfile_Click(object sender, EventArgs e) => Close();
    }
}
