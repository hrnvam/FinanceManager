using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace FinanceManager
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(Session.stringConnection);
        public RegisterForm()
        {
            InitializeComponent();
            UIHelper.SetRoundedCorners(this, 30);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                ColorTranslator.FromHtml("#ffffff"),
                ColorTranslator.FromHtml("#bed9e2"),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed);
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                       panel1.ClientRectangle,
                       ColorTranslator.FromHtml("#212121"),
                       ColorTranslator.FromHtml("#000000"),
                       LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }
        }

        private void SigninLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterSignInButton_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void RegisterShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            RegisterPassword.PasswordChar = RegisterShowPassword.Checked ? '\0' : '*';
            RegisterConfirmPassword.PasswordChar = RegisterShowPassword.Checked ? '\0' : '*';

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectUsername = "SELECT * FROM users WHERE username = @username";
                    using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@username", RegisterUsername.Text.Trim());
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();

                        adapter.Fill(table);
                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (RegisterPassword.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password, at least 8 chars are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (RegisterPassword.Text != RegisterConfirmPassword.Text)
                        {
                            MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password, date_create) VALUES(@username, @password, @date)";
                            using (SqlCommand insertUser = new SqlCommand(insertData, connect))
                            {
                                insertUser.Parameters.AddWithValue("@username", RegisterUsername.Text.Trim());
                                insertUser.Parameters.AddWithValue("@password", RegisterPassword.Text.Trim());
                                DateTime today = DateTime.Today;
                                insertUser.Parameters.AddWithValue("@date", today);

                                insertUser.ExecuteNonQuery();
                                MessageBox.Show("Registered successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 loginForm = new Form1();
                                loginForm.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Database connection is not closed.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
