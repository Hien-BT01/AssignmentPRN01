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
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }
        private void ClearText()
        {
            txtUserID.Text = string.Empty;
            txtUserEmail.Text = string.Empty;
            txtUserPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }
        private MemberObject GetUserProfile()
        {
            MemberObject user = null;
            try
            {
                user = new MemberObject
                {
                    MemberID = txtUserID.Text,
                    Email = txtUserEmail.Text,
                    Password = txtUserPassword.Text,
                    MemberName = txtUserName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get user error!");
            }
            return user;
        }
        private void DvgUserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUserProfile frmUserProfile = new frmUserProfile
            {
                Text = "Update User",
                InsertOrUpdate = true,
                UserProfile = GetUserProfile(),
                MemberRepository = memberRepository,
            };
            if (frmUserProfile.ShowDialog() == DialogResult.OK)
            {
                LoadUserList();
                //Set focus member updated
                source.Position = source.Count - 1;
            }
        }
        public void LoadUserList()
        {
            var users = memberRepository.GetListOfUsers();
            try
            {
                source = new BindingSource();
                source.DataSource = users;

                txtUserID.DataBindings.Clear();
                txtUserEmail.DataBindings.Clear();
                txtUserPassword.DataBindings.Clear();
                txtUserName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtUserID.DataBindings.Add("Text", source, "MemberID");
                txtUserEmail.DataBindings.Add("Text", source, "Email");
                txtUserPassword.DataBindings.Add("Text", source, "Password");
                txtUserName.DataBindings.Add("Text", source, "MemberName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dataGrid.DataSource = null;
                dataGrid.DataSource = source;
                if (users.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load user list error!");
            }
        }
        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dataGrid.CellDoubleClick += DvgUserList_CellDoubleClick;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmUserProfile frmUserProfile = new frmUserProfile
            {
                Text = "Add new user",
                InsertOrUpdate = false,
                MemberRepository = memberRepository,
            };
            if(frmUserProfile.ShowDialog() == DialogResult.OK)
            {
                LoadUserList();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var user = GetUserProfile();
                memberRepository.DeleteUser(user.MemberID);
                LoadUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete user error!");
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            memberRepository.SortDescending();
            LoadUserList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
