using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace FinanceManager
{
    internal class ExpensesData
    {
        string stringConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\FinanceManager.mdf;Integrated Security=True;Connect Timeout=30";
        public int ID { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string DateExpenses { get; set; }

        public List<ExpensesData> expensesListData()
        {
            List<ExpensesData> listData = new List<ExpensesData>();
            using (SqlConnection conn = new SqlConnection(stringConnect))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM expenses", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ExpensesData data = new ExpensesData();
                            data.ID = (int)reader["id"];
                            data.Category = reader["category"].ToString();
                            data.Item = reader["item"].ToString();
                            data.Amount = reader["amount"].ToString();
                            data.Description = reader["description"].ToString();
                            data.DateExpenses = ((DateTime)reader["date_expenses"]).ToString();
                            listData.Add(data);
                        }
                    }
                }
            }
            return listData;
        }
    }
}
