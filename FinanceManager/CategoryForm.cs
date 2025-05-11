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
    public partial class CategoryForm : UserControl
    {
        private int getID = 0;
        public CategoryForm()
        {
            InitializeComponent();
            displayCategoryList();
            UIHelper.StyleRoundedPanel(panel1, 12);
            UIHelper.StyleRoundedPanel(panel2, 12);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void displayCategoryList()
        {
            CategoryData data = new CategoryData();
            List<CategoryData> listData = data.categoryListData(Session.UserId);
            dataGridView1.DataSource = listData;
        }

        private void CategoryAddButton_Click(object sender, EventArgs e)
        {
            if(CategoryName.Text == "" || CategoryType.SelectedIndex == -1 || CategoryStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(Session.stringConnection))
                {
                    connect.Open();
                    using(SqlCommand cmd = new SqlCommand("INSERT INTO categories (category, type, status, date_insert, user_id) VALUES (@CategoryName, @CategoryType, @CategoryStatus, @Date, @UserId)", connect))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", CategoryName.Text);
                        cmd.Parameters.AddWithValue("@CategoryType", CategoryType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@CategoryStatus", CategoryStatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Date", DateTime.Today);
                        cmd.Parameters.AddWithValue("@UserId", Session.UserId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Category added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connect.Close();
                    clearFields();
                }
            }
            displayCategoryList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                CategoryName.Text = row.Cells["Category"].Value.ToString();
                CategoryType.SelectedItem = row.Cells["Type"].Value.ToString();
                CategoryStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void CategoryUpdateButton_Click(object sender, EventArgs e)
        {
            if (CategoryName.Text == "" || CategoryType.SelectedIndex == -1 || CategoryStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Are you sure you want to update this category?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(Session.stringConnection))
                    {
                        connect.Open();
                        string query = "UPDATE categories SET category = @CategoryName, type= @CategoryType, status = @CategoryStatus WHERE id = @id AND user_id = @UserId";
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@CategoryName", CategoryName.Text);
                            cmd.Parameters.AddWithValue("@CategoryType", CategoryType.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@CategoryStatus", CategoryStatus.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@Date", DateTime.Today);
                            cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Category updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                        clearFields();
                    }
                }
            }
            displayCategoryList();
        }
        public void clearFields()
        {
            CategoryName.Clear();
            CategoryType.SelectedIndex = -1;
            CategoryStatus.SelectedIndex = -1;
        }
        private void CategoryClearButton_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void CategoryDeleteButton_Click(object sender, EventArgs e)
        {
            if (CategoryName.Text == "" || CategoryType.SelectedIndex == -1 || CategoryStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(Session.stringConnection))
                    {
                        connect.Open();
                        string query = "DELETE FROM categories WHERE id = @id AND user_id = @UserId";
                        using (SqlCommand cmd = new SqlCommand(query, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@UserId", Session.UserId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Category deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        connect.Close();
                        clearFields();
                    }
                }
            }
            displayCategoryList();
        }
    }
}
