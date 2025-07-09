namespace Takatracker_login
{
    partial class SignupPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupPage));
            this.Email = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Create_Acc = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Email.Location = new System.Drawing.Point(343, 168);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(53, 16);
            this.Email.TabIndex = 7;
            this.Email.Text = "Name : ";
            this.Email.Click += new System.EventHandler(this.Email_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(415, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(343, 205);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(61, 16);
            this.Password.TabIndex = 9;
            this.Password.Text = "Contact : ";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(415, 203);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(533, 296);
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(107, 32);
            this.Login.TabIndex = 11;
            this.Login.Text = "Signup";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Create_Acc
            // 
            this.Create_Acc.Location = new System.Drawing.Point(415, 296);
            this.Create_Acc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create_Acc.Name = "Create_Acc";
            this.Create_Acc.Size = new System.Drawing.Size(107, 32);
            this.Create_Acc.TabIndex = 13;
            this.Create_Acc.Text = "Create Account";
            this.Create_Acc.UseVisualStyleBackColor = true;
            this.Create_Acc.Click += new System.EventHandler(this.Create_Acc_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(415, 247);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(225, 22);
            this.textBox3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Password : ";
            // 
            // SignupPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Create_Acc);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignupPage";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.SignupPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Create_Acc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
    }
}