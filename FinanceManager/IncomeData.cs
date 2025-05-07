using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FinanceManager
{
    internal class IncomeData
    {
        //string stringConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\FinanceManager.mdf;Integrated Security=True;Connect Timeout=30";
        public int ID { get; set; }
        public string Category { get; set; }
        public string Item { get; set; }
        public string Income { get; set; }
        public string Description { get; set; }
        public string DateIncome { get; set; }

        public List<IncomeData> incomeListData(int userId)
        {
            List<IncomeData> listData = new List<IncomeData>();
            using (SqlConnection conn = new SqlConnection(Session.stringConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM income WHERE user_id = @UserId", conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IncomeData data = new IncomeData();
                            data.ID = (int)reader["id"];
                            data.Category = reader["category"].ToString();
                            data.Item = reader["item"].ToString();
                            data.Income = reader["income"].ToString();
                            data.Description = reader["description"].ToString();
                            data.DateIncome = ((DateTime)reader["date_income"]).ToString();
                            listData.Add(data);
                        }
                    }
                }
            }
            return listData;
        }
    }
}
