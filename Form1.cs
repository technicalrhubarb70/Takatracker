using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takatracker_login
{
    public partial class LoginPage : Form
    {
        private DatabaseHelper dbHelper;

        public LoginPage()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                dbHelper.InitializeDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database initialization error: {ex.Message}", "Database Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize form settings
            this.Text = "Takatracker - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            
            // Set password character for password textbox
            if (txtPassword != null)
            {
                txtPassword.UseSystemPasswordChar = true;
            }

            // Update login button state
            UpdateLoginButtonState();
        }

        private void button1_Click(object sender, EventArgs e)
{
    // Login button click
    try
    {
        string username = txtUsername?.Text?.Trim() ?? "";
        string password = txtPassword?.Text ?? "";

        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter both username/email and password.", "Login Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (dbHelper.ValidateUser(username, password))
        {
            MessageBox.Show($"Welcome, {username}!", "Login Successful", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Get user ID
            int userId = dbHelper.GetUserId(username);
            
            // Hide login form and show income form
            this.Hide();
            
            // Open IncomeForm with user ID
            IncomeForm incomeForm = new IncomeForm(userId);
            incomeForm.ShowDialog();
            
            // Show login form again when income form is closed
            this.Show();
            
            // Clear fields after returning to login
            txtUsername.Clear();
            txtPassword.Clear();
        }
        else
        {
            MessageBox.Show("Invalid username/email or password.", "Login Failed", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            // Clear password field
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Login error: {ex.Message}", "Error", 
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}


        private void button2_Click(object sender, EventArgs e)
        {
            // Forgot Password button
            string email = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter your email address to reset password:", 
                "Password Reset", "");
            
            if (!string.IsNullOrEmpty(email))
            {
                try
                {
                    if (dbHelper.UserExists(email))
                    {
                        MessageBox.Show($"Password reset instructions have been sent to {email}\n(This is a demo - actual email functionality not implemented)", 
                            "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Email address not found in our system.", "Email Not Found", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking email: {ex.Message}", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create Account button
            try
            {
                var registerForm = new RegisterForm(dbHelper);
                DialogResult result = registerForm.ShowDialog();
                
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Account created successfully! You can now login.", "Registration Successful", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening registration form: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            // Test Database Connection button
            try
            {
                bool isConnected = dbHelper.TestConnection();
                MessageBox.Show(
                    isConnected ? "Database connection successful!" : "Database connection failed!",
                    "Database Test",
                    MessageBoxButtons.OK,
                    isConnected ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database test error: {ex.Message}", "Database Test Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButtonState();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButtonState();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Show/Hide password checkbox
            if (txtPassword != null)
            {
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUsername?.Focus();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Takatracker Login System\nPlease enter your credentials to continue.", 
                "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtPassword?.Focus();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // File menu item click
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Takatracker Login System\nVersion 1.0\n© 2024\n\nA secure login system with database integration.", 
                "About Takatracker", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateLoginButtonState()
        {
            if (btnLogin != null)
            {
                btnLogin.Enabled = !string.IsNullOrWhiteSpace(txtUsername?.Text) && 
                                  !string.IsNullOrWhiteSpace(txtPassword?.Text);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (btnLogin.Enabled)
                {
                    button1_Click(this, EventArgs.Empty);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
