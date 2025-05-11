using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinanceManager
{
    internal class CategoryData
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public List<CategoryData> categoryListData(int userId)
        {
            List<CategoryData> listData = new List<CategoryData>();

            using (SqlConnection connect = new SqlConnection(Session.stringConnection))
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM categories WHERE user_id = @UserId", connect))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CategoryData data = new CategoryData();
                            data.ID = reader.GetInt32(0);
                            data.Category = reader.GetString(1);
                            data.Type = reader.GetString(2);
                            data.Status = reader.GetString(3);
                            data.Date = reader.GetDateTime(4).ToString("dd/MM/yyyy");
                            listData.Add(data);
                        }
                    }
                }
                return listData;
            }
        }
    }
}
