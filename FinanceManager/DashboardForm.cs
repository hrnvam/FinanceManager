using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinanceManager
{
    public partial class DashboardForm : UserControl
    {
        //string stringConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\FinanceManager.mdf;Integrated Security=True;Connect Timeout=30";

        public DashboardForm()
        {
            InitializeComponent();
            UIHelper.StyleRoundedPanel(panel2, 12);
            UIHelper.StyleRoundedPanel(panel3, 12);
            UIHelper.StyleRoundedPanel(panel4, 12);
            LoadLineChart("month");
            LoadPieChart("month");
            LoadSummary("month");

        }

        //private void InitializePlot()
        //{
        //    DateTime[] dates = Enumerable.Range(0, 7)
        //        .Select(i => DateTime.Today.AddDays(-6 + i)).ToArray();
        //    double[] xs = dates.Select(x => x.ToOADate()).ToArray();
        //    double[] income = { 150, 200, 180, 220, 210, 230, 250 };
        //    double[] expense = { 100, 110, 105, 115, 120, 130, 125 };

        //    var plt = formsPlot1.Plot;
        //    plt.Clear();

        //    //var incomeScatter = plt.Add.Scatter(xs, income, label: "Income", color: ColorTranslator.FromHtml("#93BACB"));
        //    //var expenseScatter = plt.Add.Scatter(xs, expense, label: "Expense", color: Color.Black);

        //    var sig1 = formsPlot1.Plot.Add.Signal(income);
        //    sig1.Axes.XAxis = formsPlot1.Plot.Axes.Bottom; // standard X axis
        //    sig1.Axes.YAxis = formsPlot1.Plot.Axes.Left; // standard Y axis
        //    formsPlot1.Plot.Axes.Left.Label.Text = "Primary Y Axis";
        //    var yAxis2 = formsPlot1.Plot.Axes.AddLeftAxis();

        //    // add a new plottable and tell it to use the custom Y axis
        //    var sig2 = formsPlot1.Plot.Add.Signal(Generate.Cos(51, mult: 100));
        //    sig2.Axes.XAxis = formsPlot1.Plot.Axes.Bottom; // standard X axis
        //    sig2.Axes.YAxis = yAxis2; // custom Y axis
        //    yAxis2.LabelText = "Secondary Y Axis";
        //    formsPlot1.Plot.FigureBackground.Color = Colors.LightSkyBlue;



        //    //plt.FigureBackground = ColorTranslator.FromHtml("#D0E1E9");
        //    //plt.DataBackground = ColorTranslator.FromHtml("#D0E1E9");

        //    //plt.Axes.Bottom.Label.Text = "Date";
        //    //plt.Axes.Left.Label.Text = "Amount $";

        //    //plt.Axes.Bottom.Label.Font.Color = ColorTranslator.FromHtml("#6D7B84");
        //    //plt.Axes.Left.Label.Font.Color = ColorTranslator.FromHtml("#6D7B84");
        //    //plt.Axes.Bottom.TickLabel.Font.Color = ColorTranslator.FromHtml("#6D7B84");
        //    //plt.Axes.Left.TickLabel.Font.Color = ColorTranslator.FromHtml("#6D7B84");

        //    //plt.XAxis.DateTimeFormat("MM/dd/yyyy");

        //    //plt.Legend.IsVisible = true;
        //    //plt.Legend.Location = Alignment.UpperRight;

        //    formsPlot1.Refresh();
        //}
        public void LoadSummary(string period)
        {
            DateTime startDate;

            if (period == "week")
                startDate = DateTime.Today.AddDays(-7);
            else if (period == "month")
                startDate = DateTime.Today.AddMonths(-1);
            else if (period == "year")
                startDate = DateTime.Today.AddYears(-1);
            else
                startDate = DateTime.MinValue;

            double totalIncome = 0;
            double totalExpenses = 0;

            using (SqlConnection connect = new SqlConnection(Session.stringConnection))
            {
                connect.Open();

                using (SqlCommand incomeCmd = new SqlCommand(
                    "SELECT SUM(CAST(income AS float)) FROM income WHERE user_id = @userId AND date_income >= @startDate", connect))
                {
                    incomeCmd.Parameters.AddWithValue("@userId", Session.UserId);
                    incomeCmd.Parameters.AddWithValue("@startDate", startDate);

                    object incomeResult = incomeCmd.ExecuteScalar();
                    if (incomeResult != DBNull.Value)
                        totalIncome = Convert.ToDouble(incomeResult);
                }

                using (SqlCommand expenseCmd = new SqlCommand(
                    "SELECT SUM(CAST(amount AS float)) FROM expenses WHERE user_id = @userId AND date_expenses >= @startDate", connect))
                {
                    expenseCmd.Parameters.AddWithValue("@userId", Session.UserId);
                    expenseCmd.Parameters.AddWithValue("@startDate", startDate);

                    object expenseResult = expenseCmd.ExecuteScalar();
                    if (expenseResult != DBNull.Value)
                        totalExpenses = Convert.ToDouble(expenseResult);
                }
            }

            double balance = totalIncome - totalExpenses;

            IncomeLabel.Text = "$" + totalIncome.ToString("F2");
            ExpensesLabel.Text = "$" + totalExpenses.ToString("F2");
            string preparedBalance = balance.ToString("F2");
            BalanceLabel.Text = balance < 0 ? "- $" + preparedBalance : "$" + preparedBalance;
            BalanceLabel.ForeColor = balance < 0 ? Color.FromArgb(45, 62, 80) : Color.FromArgb(74,144,164);
        }


        private void LoadLineChart(string period)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            // Оформление оси X
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = period == "week" ? "ddd" : "dd.MM";  // Для недели формат "Пн", "Вт", а для месяца и года "dd.MM"

            Series incomeSeries = new Series("Income")
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 2,
            };

            Series expensesSeries = new Series("Expenses")
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 2,
            };

            DateTime startDate;
            string groupBySelect;
            string groupBySql;

            if (period == "week" || period == "month")
            {
                startDate = period == "week" ? DateTime.Today.AddDays(-7) : DateTime.Today.AddMonths(-1);
                groupBySelect = "CAST([Date] AS DATE) AS GroupLabel";
                groupBySql = "CAST([Date] AS DATE)";
            }
            else if (period == "year")
            {
                startDate = DateTime.Today.AddYears(-1);
                groupBySelect = "FORMAT([Date], 'yyyy-MM') AS GroupLabel";
                groupBySql = "FORMAT([Date], 'yyyy-MM')";
            }
            else
            {
                startDate = DateTime.MinValue;
                groupBySelect = "CAST([Date] AS DATE) AS GroupLabel";
                groupBySql = "CAST([Date] AS DATE)";
            }

            string query = $@"
SELECT {groupBySelect}, SUM([Income]) AS [Income], SUM([Expenses]) AS [Expenses]
FROM (
    SELECT date_income AS [Date], CAST(income AS FLOAT) AS [Income], 0 AS [Expenses]
    FROM income
    WHERE user_id = @userId AND date_income >= @startDate
    UNION ALL
    SELECT date_expenses AS [Date], 0 AS [Income], CAST(amount AS FLOAT) AS [Expenses]
    FROM expenses
    WHERE user_id = @userId AND date_expenses >= @startDate
) AS Combined
GROUP BY {groupBySql}
ORDER BY {groupBySql}";

            using (SqlConnection conn = new SqlConnection(Session.stringConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", Session.UserId);
                    cmd.Parameters.AddWithValue("@startDate", startDate);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string label = Convert.ToDateTime(reader["GroupLabel"]).ToString(
                                period == "week" ? "ddd" : "dd.MM",  // Для недели отображать "Пн", "Вт", для месяца "dd.MM"
                                new System.Globalization.CultureInfo("ru-RU"));

                            double income = Convert.ToDouble(reader["Income"]);
                            double expenses = Convert.ToDouble(reader["Expenses"]);

                            incomeSeries.Points.AddXY(label, income);
                            expensesSeries.Points.AddXY(label, expenses);
                        }
                    }
                }
            }

            chart1.Series.Add(incomeSeries);
            chart1.Series.Add(expensesSeries);
        }




        public void LoadPieChart(string period)
        {
            chart2.Series.Clear();
            chart2.Legends.Clear();

            Legend legend = new Legend("Legend");
            legend.Docking = Docking.Bottom;
            legend.BackColor = Color.FromArgb(208, 225, 233);
            legend.Font = new Font("Century Gothic", 8, FontStyle.Regular);
            chart2.Legends.Add(legend);

            Series series = new Series
            {
                Name = "TopExpenses",
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.Black,
                Font = new Font("Century Gothic", 8, FontStyle.Regular)
            };
            series["DoughnutRadius"] = "60";

            DateTime startDate;
            if (period == "week")
                startDate = DateTime.Today.AddDays(-7);
            else if (period == "month")
                startDate = DateTime.Today.AddMonths(-1);
            else if (period == "year")
                startDate = DateTime.Today.AddYears(-1);
            else
                startDate = DateTime.MinValue;

            using (SqlConnection connect = new SqlConnection(Session.stringConnection))
            {
                connect.Open();

                string query = @"
            SELECT TOP 5 category, SUM(CAST(amount AS float)) AS total 
            FROM expenses 
            WHERE user_id = @userId AND date_expenses >= @startDate
            GROUP BY category 
            ORDER BY total DESC";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@userId", Session.UserId);
                    cmd.Parameters.AddWithValue("@startDate", startDate);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string category = reader.GetString(0);
                            double amount = reader.GetDouble(1);

                            DataPoint point = new DataPoint();
                            point.YValues = new double[] { amount };
                            point.Label = "$" + amount.ToString("F2");
                            point.LegendText = category;
                            series.Points.Add(point);
                        }
                    }
                }
            }

            chart2.Series.Add(series);
        }



        private void DashboardWeekButton_Click(object sender, EventArgs e)
        {
            LoadLineChart("week");
            LoadPieChart("week");
            LoadSummary("week");
        }

        private void DashboardYearButton_Click(object sender, EventArgs e)
        {
            LoadLineChart("year");
            LoadPieChart("year");
            LoadSummary("year");
        }

        private void DashboardMonthButton_Click(object sender, EventArgs e)
        {
            LoadLineChart("month");
            LoadPieChart("month");
            LoadSummary("month");
        }

        private void DashboardForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadLineChart("month");
                LoadPieChart("month");
                LoadSummary("month");
            }
        }
    }
}
