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
    public partial class ExpensesForm : UserControl
    {
        string stringConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\FinanceManager.mdf;Integrated Security=True;Connect Timeout=30";
        private int getID = 0;

        public ExpensesForm()
        {
            InitializeComponent();
            displayCategyList();
            displayExpensesData();
        }
        public void displayExpensesData()
        {
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.expensesListData();
            dataGridView1.DataSource = listData;
        }
        public void displayCategyList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnect))
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT category FROM categories WHERE type = @type AND status = @status", connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Expenses");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    ExpensesCategory.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ExpensesCategory.Items.Add(reader["category"].ToString());
                    }
                }
                connect.Close();
            }
        }
        public void clearFields()
        {
            ExpensesCategory.SelectedIndex = -1;
            ExpensesItem.Text = "";
            ExpensesAmount.Text = "";
            ExpensesDescription.Text = "";
            ExpensesDate.Value = DateTime.Now;
        }

        private void ExpensesAddButton_Click(object sender, EventArgs e)
        {
            if (ExpensesCategory.SelectedIndex == -1 || ExpensesItem.Text.Trim() == "" || ExpensesAmount.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnect))
                {
                    connect.Open();
                    string query = "INSERT INTO expenses (category, item, amount, description, date_expenses, date_insert)" +
                        "VALUES (@cat, @item, @amount, @desc, @date_e, @date)";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", ExpensesCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@item", ExpensesItem.Text);
                        cmd.Parameters.AddWithValue("@amount", ExpensesAmount.Text);
                        cmd.Parameters.AddWithValue("@desc", ExpensesDescription.Text);
                        cmd.Parameters.AddWithValue("@date_e", ExpensesDate.Value);
                        cmd.Parameters.AddWithValue("@date", DateTime.Today);

                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
            }
            displayExpensesData();
        }

        private void ExpensesClearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void ExpensesUpdateButton_Click(object sender, EventArgs e)
        {
            if (ExpensesCategory.SelectedIndex == -1 || ExpensesItem.Text.Trim() == "" || ExpensesAmount.Text.Trim() == "")
            {
                MessageBox.Show("Please item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnect))
                {
                    connect.Open();

                    string query = "UPDATE expenses SET category=@cat, item=@item, amount=@amount, " +
                                   "description=@desc, date_expenses=@date_e WHERE id=@id";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@cat", ExpensesCategory.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@item", ExpensesItem.Text);
                        cmd.Parameters.AddWithValue("@amount", ExpensesAmount.Text);
                        cmd.Parameters.AddWithValue("@desc", ExpensesDescription.Text);
                        cmd.Parameters.AddWithValue("@date_e", ExpensesDate.Value);
                        cmd.Parameters.AddWithValue("@id", getID);

                        cmd.ExecuteNonQuery();
                        clearFields();
                        MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    connect.Close();
                }
            }
            displayExpensesData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                ExpensesCategory.SelectedItem = row.Cells[1].Value.ToString();
                ExpensesItem.Text = row.Cells[2].Value.ToString();
                ExpensesAmount.Text = row.Cells[3].Value.ToString();
                ExpensesDescription.Text = row.Cells[4].Value.ToString();
                ExpensesDate.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }

        private void ExpensesDeleteButton_Click(object sender, EventArgs e)
        {
            if (ExpensesCategory.SelectedIndex == -1 || ExpensesItem.Text.Trim() == "" || ExpensesAmount.Text.Trim() == "")
            {
                MessageBox.Show("Please item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnect))
                    {
                        connect.Open();

                        string query = "DELETE FROM expenses WHERE id=@id";

                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();
                            MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                    }
                }
            }
            displayExpensesData();
        }
    }
}
