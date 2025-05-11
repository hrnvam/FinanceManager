namespace FinanceManager
{
    partial class RegisterForm
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
            this.SignUpButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterSignInButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisterShowPassword = new System.Windows.Forms.CheckBox();
            this.RegisterPassword = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegisterUsername = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.SigninLabel = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.RegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.SignUpButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(168)))));
            this.SignUpButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(145)))), ((int)(((byte)(168)))));
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.SignUpButton.ForeColor = System.Drawing.Color.Black;
            this.SignUpButton.Location = new System.Drawing.Point(637, 447);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(129, 48);
            this.SignUpButton.TabIndex = 21;
            this.SignUpButton.Text = "SIGNUP";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.RegisterSignInButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 577);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RegisterSignInButton
            // 
            this.RegisterSignInButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterSignInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(132)))));
            this.RegisterSignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(132)))));
            this.RegisterSignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterSignInButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.RegisterSignInButton.ForeColor = System.Drawing.Color.White;
            this.RegisterSignInButton.Location = new System.Drawing.Point(62, 444);
            this.RegisterSignInButton.Name = "RegisterSignInButton";
            this.RegisterSignInButton.Size = new System.Drawing.Size(334, 49);
            this.RegisterSignInButton.TabIndex = 14;
            this.RegisterSignInButton.Text = "SIGN IN";
            this.RegisterSignInButton.UseVisualStyleBackColor = false;
            this.RegisterSignInButton.Click += new System.EventHandler(this.RegisterSignInButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(159, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "SIGN IN HERE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.label4.Location = new System.Drawing.Point(12, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trackify - Your Income and Expenses";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RegisterShowPassword
            // 
            this.RegisterShowPassword.AutoSize = true;
            this.RegisterShowPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegisterShowPassword.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.RegisterShowPassword.ForeColor = System.Drawing.Color.Black;
            this.RegisterShowPassword.Location = new System.Drawing.Point(726, 405);
            this.RegisterShowPassword.Name = "RegisterShowPassword";
            this.RegisterShowPassword.Size = new System.Drawing.Size(151, 23);
            this.RegisterShowPassword.TabIndex = 22;
            this.RegisterShowPassword.Text = "Show Password";
            this.RegisterShowPassword.UseVisualStyleBackColor = false;
            this.RegisterShowPassword.CheckedChanged += new System.EventHandler(this.RegisterShowPassword_CheckedChanged);
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.RegisterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterPassword.Location = new System.Drawing.Point(519, 281);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.PasswordChar = '*';
            this.RegisterPassword.Size = new System.Drawing.Size(359, 26);
            this.RegisterPassword.TabIndex = 20;
            this.RegisterPassword.TextChanged += new System.EventHandler(this.LoginPassword_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.Location = new System.Drawing.Point(517, 243);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 23);
            this.PasswordLabel.TabIndex = 19;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // RegisterUsername
            // 
            this.RegisterUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.RegisterUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterUsername.Location = new System.Drawing.Point(519, 197);
            this.RegisterUsername.Name = "RegisterUsername";
            this.RegisterUsername.Size = new System.Drawing.Size(359, 26);
            this.RegisterUsername.TabIndex = 18;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UsernameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.UsernameLabel.ForeColor = System.Drawing.Color.Black;
            this.UsernameLabel.Location = new System.Drawing.Point(517, 160);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(108, 23);
            this.UsernameLabel.TabIndex = 17;
            this.UsernameLabel.Text = "Username";
            // 
            // SigninLabel
            // 
            this.SigninLabel.AutoSize = true;
            this.SigninLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SigninLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SigninLabel.ForeColor = System.Drawing.Color.Black;
            this.SigninLabel.Location = new System.Drawing.Point(637, 87);
            this.SigninLabel.Name = "SigninLabel";
            this.SigninLabel.Size = new System.Drawing.Size(113, 28);
            this.SigninLabel.TabIndex = 16;
            this.SigninLabel.Text = "REGISTER";
            this.SigninLabel.Click += new System.EventHandler(this.SigninLabel_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(907, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 15;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // RegisterConfirmPassword
            // 
            this.RegisterConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.RegisterConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RegisterConfirmPassword.Location = new System.Drawing.Point(519, 363);
            this.RegisterConfirmPassword.Name = "RegisterConfirmPassword";
            this.RegisterConfirmPassword.PasswordChar = '*';
            this.RegisterConfirmPassword.Size = new System.Drawing.Size(359, 26);
            this.RegisterConfirmPassword.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(517, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Confirm Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::FinanceManager.Properties.Resources.logo_128;
            this.pictureBox1.Location = new System.Drawing.Point(163, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(939, 577);
            this.Controls.Add(this.RegisterConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RegisterShowPassword);
            this.Controls.Add(this.RegisterPassword);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.RegisterUsername);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SigninLabel);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button RegisterSignInButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox RegisterShowPassword;
        private System.Windows.Forms.TextBox RegisterPassword;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox RegisterUsername;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label SigninLabel;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.TextBox RegisterConfirmPassword;
        private System.Windows.Forms.Label label1;
    }
}