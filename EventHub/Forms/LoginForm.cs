/*
* Name: Lindokuhle Nkosi
* Student Number: EDUV10933182
* Module Name: Basic C# Programming
* Module Code: ITECA0-22
* Date: 06/06/2026
* Purpose: Event Booking System
*/

using System;
using System.Windows.Forms;

namespace EventHub
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cboMembers.DataSource = DataStore.Members;

            cboMembers.DisplayMember = "Name";

            cboMembers.SelectedIndex = -1;
        }

        // Validates selected role and opens the dashboard
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboRole.SelectedItem.ToString() == "Member")
                {
                    Member selectedMember =
                        (Member)cboMembers.SelectedItem;

                    // BLOCK if password is not entered
                    if (string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        MessageBox.Show("Please enter password.");
                        return;
                    }

                    // BLOCK if wrong password is entered
                    if (selectedMember.Password != txtPassword.Text)
                    {
                        MessageBox.Show("Incorrect password.");
                        return;
                    }

                    // Login success
                    MemberForm frm = new MemberForm(selectedMember);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    // Admin login (NO PASSWORD REQUIRED)
                    AdminForm frm = new AdminForm();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cboRole.SelectedItem.ToString() == "Member")
                {
                    lblMember.Visible = true;
                    cboMembers.Visible = true;
                    lblPassword.Visible = true;
                    txtPassword.Visible = true;
                }
                else
                {
                    lblMember.Visible = false;
                    cboMembers.Visible = false;
                    lblPassword.Visible = false;
                    txtPassword.Visible = false;
                }
            }
        }
    }
}
