using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class DashboardForm : UserControl
    {
        string stringConnect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\FinanceManager.mdf;Integrated Security=True;Connect Timeout=30";

        public DashboardForm()
        {
            InitializeComponent();
            UIHelper.StyleRoundedPanel(panel2, 12);
            UIHelper.StyleRoundedPanel(panel3, 12);
            UIHelper.StyleRoundedPanel(panel4, 12);

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


        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
