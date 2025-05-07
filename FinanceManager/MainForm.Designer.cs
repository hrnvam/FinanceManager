namespace FinanceManager
{
    partial class MainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ExpensesButton = new System.Windows.Forms.Button();
            this.IncomeButton = new System.Windows.Forms.Button();
            this.CategoryButton = new System.Windows.Forms.Button();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.incomeForm11 = new FinanceManager.IncomeForm1();
            this.dashboardForm1 = new FinanceManager.DashboardForm();
            this.expensesForm1 = new FinanceManager.ExpensesForm();
            this.categoryForm1 = new FinanceManager.CategoryForm();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.LogoutButton);
            this.panel2.Controls.Add(this.ExpensesButton);
            this.panel2.Controls.Add(this.IncomeButton);
            this.panel2.Controls.Add(this.CategoryButton);
            this.panel2.Controls.Add(this.DashboardButton);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 700);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = global::FinanceManager.Properties.Resources.logout_24_1_;
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(12, 572);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(235, 44);
            this.LogoutButton.TabIndex = 6;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ExpensesButton
            // 
            this.ExpensesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExpensesButton.FlatAppearance.BorderSize = 0;
            this.ExpensesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ExpensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpensesButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ExpensesButton.ForeColor = System.Drawing.Color.White;
            this.ExpensesButton.Image = global::FinanceManager.Properties.Resources.expense_24_1_;
            this.ExpensesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExpensesButton.Location = new System.Drawing.Point(12, 400);
            this.ExpensesButton.Name = "ExpensesButton";
            this.ExpensesButton.Size = new System.Drawing.Size(235, 44);
            this.ExpensesButton.TabIndex = 5;
            this.ExpensesButton.Text = "Expenses";
            this.ExpensesButton.UseVisualStyleBackColor = false;
            this.ExpensesButton.Click += new System.EventHandler(this.ExpensesButton_Click);
            // 
            // IncomeButton
            // 
            this.IncomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IncomeButton.FlatAppearance.BorderSize = 0;
            this.IncomeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.IncomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeButton.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IncomeButton.ForeColor = System.Drawing.Color.White;
            this.IncomeButton.Image = global::FinanceManager.Properties.Resources.income_24_1_;
            this.IncomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IncomeButton.Location = new System.Drawing.Point(12, 334);
            this.IncomeButton.Name = "IncomeButton";
            this.IncomeButton.Size = new System.Drawing.Size(235, 44);
            this.IncomeButton.TabIndex = 4;
            this.IncomeButton.Text = "Income";
            this.IncomeButton.UseVisualStyleBackColor = false;
            this.IncomeButton.Click += new System.EventHandler(this.IncomeButton_Click);
            // 
            // CategoryButton
            // 
            this.CategoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CategoryButton.FlatAppearance.BorderSize = 0;
            this.CategoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CategoryButton.ForeColor = System.Drawing.Color.White;
            this.CategoryButton.Image = global::FinanceManager.Properties.Resources.categories_24_1_;
            this.CategoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CategoryButton.Location = new System.Drawing.Point(12, 268);
            this.CategoryButton.Name = "CategoryButton";
            this.CategoryButton.Size = new System.Drawing.Size(235, 44);
            this.CategoryButton.TabIndex = 3;
            this.CategoryButton.Text = "     Add Category";
            this.CategoryButton.UseVisualStyleBackColor = false;
            this.CategoryButton.Click += new System.EventHandler(this.CategoryButton_Click);
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.Image = global::FinanceManager.Properties.Resources.dash_24;
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.Location = new System.Drawing.Point(12, 191);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(235, 44);
            this.DashboardButton.TabIndex = 2;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox2.Image = global::FinanceManager.Properties.Resources.logo_64;
            this.pictureBox2.Location = new System.Drawing.Point(71, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(1164, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 2;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.incomeForm11);
            this.panel1.Controls.Add(this.dashboardForm1);
            this.panel1.Controls.Add(this.expensesForm1);
            this.panel1.Controls.Add(this.categoryForm1);
            this.panel1.Location = new System.Drawing.Point(271, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 648);
            this.panel1.TabIndex = 3;
            // 
            // incomeForm11
            // 
            this.incomeForm11.Location = new System.Drawing.Point(0, 0);
            this.incomeForm11.Name = "incomeForm11";
            this.incomeForm11.Size = new System.Drawing.Size(924, 648);
            this.incomeForm11.TabIndex = 4;
            this.incomeForm11.Load += new System.EventHandler(this.incomeForm11_Load);
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dashboardForm1.Location = new System.Drawing.Point(3, 0);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(924, 648);
            this.dashboardForm1.TabIndex = 3;
            this.dashboardForm1.Load += new System.EventHandler(this.dashboardForm1_Load);
            // 
            // expensesForm1
            // 
            this.expensesForm1.Location = new System.Drawing.Point(3, 0);
            this.expensesForm1.Name = "expensesForm1";
            this.expensesForm1.Size = new System.Drawing.Size(924, 648);
            this.expensesForm1.TabIndex = 2;
            // 
            // categoryForm1
            // 
            this.categoryForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categoryForm1.Location = new System.Drawing.Point(3, 0);
            this.categoryForm1.Name = "categoryForm1";
            this.categoryForm1.Size = new System.Drawing.Size(924, 648);
            this.categoryForm1.TabIndex = 0;
            this.categoryForm1.Load += new System.EventHandler(this.categoryForm1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Button ExpensesButton;
        private System.Windows.Forms.Button IncomeButton;
        private System.Windows.Forms.Button CategoryButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Panel panel1;
        private CategoryForm categoryForm1;
        private ExpensesForm expensesForm1;
        private DashboardForm dashboardForm1;
        private IncomeForm1 incomeForm11;
    }
}