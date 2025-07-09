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
    public partial class IncomeForm : Form
    {
        private int currentUserId;

        public IncomeForm(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set form properties
            this.Text = "Takatracker - Income Entry";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Set default date to today
            dtpIncomeDate.Value = DateTime.Now;

            // Populate category dropdown
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Salary and wages");
            cmbCategory.Items.Add("Freelance or side income");
            cmbCategory.Items.Add("Rental income");
            cmbCategory.SelectedIndex = 0; // Default to first item

            // Set focus to amount field
            txtAmount.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (!ValidateInput())
                    return;

                // Get values
                DateTime incomeDate = dtpIncomeDate.Value;
                decimal amount = decimal.Parse(txtAmount.Text);
                string category = cmbCategory.SelectedItem.ToString();

                // Save to database
                DatabaseHelper dbHelper = new DatabaseHelper();
                
                bool saved = dbHelper.SaveIncome(currentUserId, amount, category, incomeDate);
                
                if (saved)
                {
                    string message = $"Income Entry Saved Successfully!\n\n" +
                               $"Date: {incomeDate.ToShortDateString()}\n" +
                               $"Amount: ${amount:F2}\n" +
                               $"Category: {category}";

                    MessageBox.Show(message, "Income Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to save income entry.", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving income: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Validate amount
            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter an amount.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            // Validate category
            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategory.Focus();
                return false;
            }

            // Validate date (shouldn't be in future)
            if (dtpIncomeDate.Value.Date > DateTime.Now.Date)
            {
                DialogResult result = MessageBox.Show("The selected date is in the future. Do you want to continue?", 
                    "Future Date Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.No)
                {
                    dtpIncomeDate.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ClearForm()
        {
            txtAmount.Clear();
            dtpIncomeDate.Value = DateTime.Now;
            cmbCategory.SelectedIndex = 0;
            txtAmount.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear all fields?", 
                "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                ClearForm();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers, decimal point, backspace, and delete
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && txtAmount.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            // Format the amount when leaving the textbox
            if (!string.IsNullOrEmpty(txtAmount.Text) && decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                txtAmount.Text = amount.ToString("0.00");
            }
        }

        // Navigation methods
        private void btnNavExpense_Click(object sender, EventArgs e)
        {
            try
            {
                ExpenseForm expenseForm = new ExpenseForm();
                expenseForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Expense form: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNavSavingGoal_Click(object sender, EventArgs e)
        {
            try
            {
                SavingGoalForm savingGoalForm = new SavingGoalForm();
                savingGoalForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Saving Goal form: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNavHistory_Click(object sender, EventArgs e)
        {
            try
            {
                HistoryForm historyForm = new HistoryForm();
                historyForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening History form: {ex.Message}", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNavIncome_Click(object sender, EventArgs e)
        {
            // Already on income form, just show message or refresh
            MessageBox.Show("You are already on the Income form.", "Information", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
