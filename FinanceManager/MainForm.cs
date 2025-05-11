using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UIHelper.SetRoundedCorners(this, 30);
            dashboardForm1.Visible = true;
            categoryForm1.Visible = false;
            incomeForm11.Visible = false;
            expensesForm1.Visible = false;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                ColorTranslator.FromHtml("#ffffff"),
                ColorTranslator.FromHtml("#D0E9F2"),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //UIHelper.StyleRoundedButton(DashboardButton, 12);
            //UIHelper.StyleRoundedButton(CategoryButton, 12);
            //UIHelper.StyleRoundedButton(IncomeButton, 12);
            //UIHelper.StyleRoundedButton(ExpensesButton, 12);
            //UIHelper.StyleRoundedButton(LogoutButton, 12);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                       panel2.ClientRectangle,
                       ColorTranslator.FromHtml("#000000"),
                       ColorTranslator.FromHtml("#212121"),
                       LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, panel2.ClientRectangle);
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void categoryForm1_Load(object sender, EventArgs e)
        {

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = true;
            categoryForm1.Visible = false;
            incomeForm11.Visible = false;
            expensesForm1.Visible = false;
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = true;
            incomeForm11.Visible = false;
            expensesForm1.Visible = false;
        }

        private void IncomeButton_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm11.Visible = true;
            expensesForm1.Visible = false;
        }

        private void ExpensesButton_Click(object sender, EventArgs e)
        {
            dashboardForm1.Visible = false;
            categoryForm1.Visible = false;
            incomeForm11.Visible = false;
            expensesForm1.Visible = true;
        }

        private void incomeForm11_Load(object sender, EventArgs e)
        {

        }

        private void dashboardForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
