using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager
{
    public static class Session
    {
        public static string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\FinanceManager_test.mdf;Integrated Security=True;Connect Timeout=30";

        public static int UserId { get; set; }
    }
}
