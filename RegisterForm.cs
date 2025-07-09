using System;
using System.Drawing;
using System.Windows.Forms;

namespace Takatracker_login
{
    public partial class RegisterForm : Form
    {
        private DatabaseHelper dbHelper;

        public RegisterForm(DatabaseHelper databaseHelper)
        {
            dbHelper = databaseHelper;
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Set password character
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;
            
            // Focus on first field
            txtUsername.Focus();
            
            // Initial button state
            btnRegister.Enabled = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            CheckFormValid();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            CheckFormValid();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            CheckFormValid();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            CheckFormValid();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string email = txtEmail.Text.Trim();
                string password = txtPassword.Text;

                // Create user
                if (dbHelper.CreateUser(username, email, password))
                {
                    MessageBox.Show("Account created successfully!", "Success", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create account. Username or email may already exist.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CheckFormValid()
        {
            bool isValid = !string.IsNullOrWhiteSpace(txtUsername.Text) &&
                          !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                          !string.IsNullOrWhiteSpace(txtPassword.Text) &&
                          !string.IsNullOrWhiteSpace(txtConfirmPassword.Text) &&
                          txtPassword.Text == txtConfirmPassword.Text &&
                          txtUsername.Text.Length >= 3 &&
                          txtPassword.Text.Length >= 6;

            btnRegister.Enabled = isValid;
        }
    }
}
