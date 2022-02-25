namespace MyStoreWinApp
{
    partial class frmUserProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserEmail = new System.Windows.Forms.Label();
            this.lbUserPassword = new System.Windows.Forms.Label();
            this.lbUserCity = new System.Windows.Forms.Label();
            this.lbUserCountry = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserCity = new System.Windows.Forms.TextBox();
            this.txtUserCountry = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btnCloseProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(89, 33);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(57, 20);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "User ID";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(89, 150);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(82, 20);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "User Name";
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.AutoSize = true;
            this.lbUserEmail.Location = new System.Drawing.Point(89, 72);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(79, 20);
            this.lbUserEmail.TabIndex = 0;
            this.lbUserEmail.Text = "User Email";
            // 
            // lbUserPassword
            // 
            this.lbUserPassword.AutoSize = true;
            this.lbUserPassword.Location = new System.Drawing.Point(89, 112);
            this.lbUserPassword.Name = "lbUserPassword";
            this.lbUserPassword.Size = new System.Drawing.Size(103, 20);
            this.lbUserPassword.TabIndex = 0;
            this.lbUserPassword.Text = "User Password";
            // 
            // lbUserCity
            // 
            this.lbUserCity.AutoSize = true;
            this.lbUserCity.Location = new System.Drawing.Point(89, 188);
            this.lbUserCity.Name = "lbUserCity";
            this.lbUserCity.Size = new System.Drawing.Size(67, 20);
            this.lbUserCity.TabIndex = 0;
            this.lbUserCity.Text = "User City";
            // 
            // lbUserCountry
            // 
            this.lbUserCountry.AutoSize = true;
            this.lbUserCountry.Location = new System.Drawing.Point(89, 234);
            this.lbUserCountry.Name = "lbUserCountry";
            this.lbUserCountry.Size = new System.Drawing.Size(93, 20);
            this.lbUserCountry.TabIndex = 0;
            this.lbUserCountry.Text = "User Country";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(216, 26);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(245, 27);
            this.txtUserID.TabIndex = 1;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(216, 65);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(245, 27);
            this.txtUserEmail.TabIndex = 1;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(216, 105);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(245, 27);
            this.txtUserPassword.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(216, 147);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(245, 27);
            this.txtUserName.TabIndex = 1;
            // 
            // txtUserCity
            // 
            this.txtUserCity.Location = new System.Drawing.Point(216, 185);
            this.txtUserCity.Name = "txtUserCity";
            this.txtUserCity.Size = new System.Drawing.Size(245, 27);
            this.txtUserCity.TabIndex = 1;
            // 
            // txtUserCountry
            // 
            this.txtUserCountry.Location = new System.Drawing.Point(216, 227);
            this.txtUserCountry.Name = "txtUserCountry";
            this.txtUserCountry.Size = new System.Drawing.Size(245, 27);
            this.txtUserCountry.TabIndex = 1;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveProfile.Location = new System.Drawing.Point(216, 287);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(109, 32);
            this.btnSaveProfile.TabIndex = 2;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btnCloseProfile
            // 
            this.btnCloseProfile.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseProfile.Location = new System.Drawing.Point(352, 287);
            this.btnCloseProfile.Name = "btnCloseProfile";
            this.btnCloseProfile.Size = new System.Drawing.Size(109, 32);
            this.btnCloseProfile.TabIndex = 2;
            this.btnCloseProfile.Text = "Close";
            this.btnCloseProfile.UseVisualStyleBackColor = true;
            this.btnCloseProfile.Click += new System.EventHandler(this.btnCloseProfile_Click);
            // 
            // frmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseProfile);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.txtUserCountry);
            this.Controls.Add(this.txtUserCity);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lbUserEmail);
            this.Controls.Add(this.lbUserPassword);
            this.Controls.Add(this.lbUserCountry);
            this.Controls.Add(this.lbUserCity);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.lbUserID);
            this.Name = "frmUserProfile";
            this.Text = "frmUserProfile";
            this.Load += new System.EventHandler(this.frmUserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserEmail;
        private System.Windows.Forms.Label lbUserPassword;
        private System.Windows.Forms.Label lbUserCity;
        private System.Windows.Forms.Label lbUserCountry;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserCity;
        private System.Windows.Forms.TextBox txtUserCountry;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btnCloseProfile;
    }
}