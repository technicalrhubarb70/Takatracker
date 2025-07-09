namespace Takatracker_login
{
    partial class IncomeForm
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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnNavHistory = new System.Windows.Forms.Button();
            this.btnNavSavingGoal = new System.Windows.Forms.Button();
            this.btnNavExpense = new System.Windows.Forms.Button();
            this.btnNavIncome = new System.Windows.Forms.Button();
            this.lblNavTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpIncomeDate = new System.Windows.Forms.DateTimePicker();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.panelNavigation.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panelNavigation.Controls.Add(this.btnLogout);
            this.panelNavigation.Controls.Add(this.btnNavHistory);
            this.panelNavigation.Controls.Add(this.btnNavSavingGoal);
            this.panelNavigation.Controls.Add(this.btnNavExpense);
            this.panelNavigation.Controls.Add(this.btnNavIncome);
            this.panelNavigation.Controls.Add(this.lblNavTitle);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(250, 600);
            this.panelNavigation.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 550);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 50);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "🚪 Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnNavHistory
            // 
            this.btnNavHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnNavHistory.FlatAppearance.BorderSize = 0;
            this.btnNavHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHistory.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNavHistory.ForeColor = System.Drawing.Color.White;
            this.btnNavHistory.Location = new System.Drawing.Point(0, 280);
            this.btnNavHistory.Name = "btnNavHistory";
            this.btnNavHistory.Size = new System.Drawing.Size(250, 60);
            this.btnNavHistory.TabIndex = 5;
            this.btnNavHistory.Text = "📊 History";
            this.btnNavHistory.UseVisualStyleBackColor = false;
            this.btnNavHistory.Click += new System.EventHandler(this.btnNavHistory_Click);
            // 
            // btnNavSavingGoal
            // 
            this.btnNavSavingGoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnNavSavingGoal.FlatAppearance.BorderSize = 0;
            this.btnNavSavingGoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSavingGoal.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNavSavingGoal.ForeColor = System.Drawing.Color.White;
            this.btnNavSavingGoal.Location = new System.Drawing.Point(0, 220);
            this.btnNavSavingGoal.Name = "btnNavSavingGoal";
            this.btnNavSavingGoal.Size = new System.Drawing.Size(250, 60);
            this.btnNavSavingGoal.TabIndex = 4;
            this.btnNavSavingGoal.Text = "🎯 Saving Goal";
            this.btnNavSavingGoal.UseVisualStyleBackColor = false;
            this.btnNavSavingGoal.Click += new System.EventHandler(this.btnNavSavingGoal_Click);
            // 
            // btnNavExpense
            // 
                        this.btnNavExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btnNavExpense.FlatAppearance.BorderSize = 0;
            this.btnNavExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavExpense.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNavExpense.ForeColor = System.Drawing.Color.White;
            this.btnNavExpense.Location = new System.Drawing.Point(0, 160);
            this.btnNavExpense.Name = "btnNavExpense";
            this.btnNavExpense.Size = new System.Drawing.Size(250, 60);
            this.btnNavExpense.TabIndex = 3;
            this.btnNavExpense.Text = "💸 Expense";
            this.btnNavExpense.UseVisualStyleBackColor = false;
            this.btnNavExpense.Click += new System.EventHandler(this.btnNavExpense_Click);
            // 
            // btnNavIncome
            // 
            this.btnNavIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnNavIncome.FlatAppearance.BorderSize = 0;
            this.btnNavIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavIncome.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNavIncome.ForeColor = System.Drawing.Color.White;
            this.btnNavIncome.Location = new System.Drawing.Point(0, 100);
            this.btnNavIncome.Name = "btnNavIncome";
            this.btnNavIncome.Size = new System.Drawing.Size(250, 60);
            this.btnNavIncome.TabIndex = 2;
            this.btnNavIncome.Text = "💰 Income";
            this.btnNavIncome.UseVisualStyleBackColor = false;
            this.btnNavIncome.Click += new System.EventHandler(this.btnNavIncome_Click);
            // 
            // lblNavTitle
            // 
            this.lblNavTitle.AutoSize = true;
            this.lblNavTitle.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavTitle.ForeColor = System.Drawing.Color.White;
            this.lblNavTitle.Location = new System.Drawing.Point(50, 30);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Size = new System.Drawing.Size(150, 32);
            this.lblNavTitle.TabIndex = 1;
            this.lblNavTitle.Text = "Takatracker";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelMain.Controls.Add(this.lblCurrency);
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Controls.Add(this.lblDate);
            this.panelMain.Controls.Add(this.btnClear);
            this.panelMain.Controls.Add(this.dtpIncomeDate);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.lblAmount);
            this.panelMain.Controls.Add(this.cmbCategory);
            this.panelMain.Controls.Add(this.txtAmount);
            this.panelMain.Controls.Add(this.lblCategory);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(250, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(750, 600);
            this.panelMain.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblTitle.Location = new System.Drawing.Point(50, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Income Entry";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblDate.Location = new System.Drawing.Point(50, 150);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 28);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // dtpIncomeDate
            // 
            this.dtpIncomeDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIncomeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIncomeDate.Location = new System.Drawing.Point(200, 150);
            this.dtpIncomeDate.Name = "dtpIncomeDate";
            this.dtpIncomeDate.Size = new System.Drawing.Size(350, 30);
            this.dtpIncomeDate.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblAmount.Location = new System.Drawing.Point(50, 220);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(89, 28);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(240, 220);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(310, 30);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblCategory.Location = new System.Drawing.Point(50, 290);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(101, 28);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(200, 290);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(350, 33);
            this.cmbCategory.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(200, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(330, 380);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 45);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(460, 380);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblCurrency.Location = new System.Drawing.Point(200, 220);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(25, 28);
            this.lblCurrency.TabIndex = 10;
            this.lblCurrency.Text = "$";
            // 
            // IncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelNavigation);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "IncomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Takatracker - Income Entry";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelNavigation.ResumeLayout(false);
            this.panelNavigation.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

                #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.Button btnNavIncome;
        private System.Windows.Forms.Button btnNavExpense;
        private System.Windows.Forms.Button btnNavSavingGoal;
        private System.Windows.Forms.Button btnNavHistory;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpIncomeDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCurrency;
    }
}
