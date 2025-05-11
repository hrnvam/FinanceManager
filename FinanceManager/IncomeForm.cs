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

namespace FinanceManager
{
    public partial class IncomeForm : UserControl
    {
        private int getID = 0;
        public IncomeForm()
        {
            InitializeComponent();
            displayCategyList();
            displayIncomeData();
        }

        public void displayIncomeData()
        {
            IncomeData iData = new IncomeData();
            List<IncomeData> listData = iData.incomeListData(Session.UserId);
            dataGridView1.DataSource = listData;
        }
        public void displayCategyList()
        {
            using(SqlConnection connect = new SqlConnection(Session.stringConnection))
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT category FROM categories WHERE type = @type AND status = @status AND user_id = @UserId", connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");
                    cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                    IncomeCategory.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IncomeCategory.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void IncomeAddButton_Click(object sender, EventArgs e)
        {
            if(IncomeCategory.SelectedIndex == -1 || IncomeItem.Text.Trim() == "" || IncomeIncome.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                using(SqlConnection connect = new SqlConnection(Session.stringConnection))
                {
                    connect.Open();
                    string query = "INSERT INTO income (category, item, income, description, date_income, date_insert, user_id)" +
                        "VALUES (@cat, @item, @income, @desc, @date_i, @date, @userId)";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", IncomeCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@item", IncomeItem.Text);
                        cmd.Parameters.AddWithValue("@income", IncomeIncome.Text);
                        cmd.Parameters.AddWithValue("@desc", IncomeDescription.Text);
                        cmd.Parameters.AddWithValue("@date_i", IncomeDate.Value);
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);
                        cmd.Parameters.AddWithValue("@userId", Session.UserId);

                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
            }
            displayIncomeData();
        }

        public void clearFields()
        {
            IncomeCategory.SelectedIndex = -1;
            IncomeItem.Text = "";
            IncomeIncome.Text = "";
            IncomeDescription.Text = "";
            IncomeDate.Value = DateTime.Now;
        }
        private void IncomeClearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void IncomeUpdateButton_Click(object sender, EventArgs e)
        {
            if (IncomeCategory.SelectedIndex == -1 || IncomeItem.Text.Trim() == "" || IncomeIncome.Text.Trim() == "")
            {
                MessageBox.Show("Please item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(Session.stringConnection))
                {
                    connect.Open();

                    string query = "UPDATE income SET category=@cat, item=@item, income=@income, " +
                                   "description=@desc, date_income=@date_i WHERE id=@id AND user_id=@userId";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", IncomeCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@item", IncomeItem.Text);
                        cmd.Parameters.AddWithValue("@income", IncomeIncome.Text);
                        cmd.Parameters.AddWithValue("@desc", IncomeDescription.Text);
                        cmd.Parameters.AddWithValue("@date_i", IncomeDate.Value);
                        cmd.Parameters.AddWithValue("@id", getID);
                        cmd.Parameters.AddWithValue("@userId", Session.UserId);

                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
            }
            displayIncomeData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                IncomeCategory.SelectedItem = row.Cells[1].Value.ToString();
                IncomeItem.Text = row.Cells[2].Value.ToString();
                IncomeIncome.Text = row.Cells[3].Value.ToString();
                IncomeDescription.Text = row.Cells[4].Value.ToString();
                IncomeDate.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }

        private void IncomeDeleteButton_Click(object sender, EventArgs e)
        {
            if (IncomeCategory.SelectedIndex == -1 || IncomeItem.Text.Trim() == "" || IncomeIncome.Text.Trim() == "")
            {
                MessageBox.Show("Please item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(Session.stringConnection))
                    {
                        connect.Open();

                        string query = "DELETE FROM income WHERE id=@id AND user_id=@userId";

                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@userId", Session.UserId);

                            cmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                    }
                }
            }
            displayIncomeData();
        }

        private void IncomeForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                displayCategyList();
            }
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    Console.WriteLine($"{btn.Name}: {btn.FlatStyle}");

                }
            }
        }
    }
}
