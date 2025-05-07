using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager
{
    internal class UIHelper
    {
        public static void SetRoundedCorners(Form form, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(form.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(form.Width - radius, form.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, form.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            form.Region = new Region(path);
        }

        public static GraphicsPath GetRoundedRectPath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        public static void StyleRoundedPanel(Panel panel, int cornerRadius)
        {
            panel.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = GetRoundedRectPath(panel.ClientRectangle, cornerRadius))
                {
                    panel.Region = new Region(path);
                }
            };
        }

        public static void StyleRoundedButton(Button button, int cornerRadius, Color borderColor = default, int borderWidth =0)
        {
            button.Region = new Region(GetRoundedRectPath(button.ClientRectangle, cornerRadius));
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;

            button.Paint += (s, pe) =>
            {
                using (Pen borderPen = new Pen(borderColor, borderWidth))
                {
                    pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    GraphicsPath path = GetRoundedRectPath(button.ClientRectangle, cornerRadius);
                    pe.Graphics.DrawPath(borderPen, path);
                }
            };
        }

        public static void StyleRoundedTextBox(TextBox textBox, int cornerRadius, Color borderColor, int borderWidth = 2)
        {
            textBox.BorderStyle = BorderStyle.None;
            textBox.Region = new Region(GetRoundedRectPath(textBox.ClientRectangle, cornerRadius));
            textBox.Padding = new Padding(20, 10, 10, 10);
            textBox.MinimumSize = new Size(200, 40);

            textBox.Paint += (s, pe) =>
            {
                using (Pen borderPen = new Pen(borderColor, borderWidth))
                {
                    pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    GraphicsPath path = GetRoundedRectPath(textBox.ClientRectangle, cornerRadius);
                    pe.Graphics.DrawPath(borderPen, path);
                }
            };
        }
    }
}
