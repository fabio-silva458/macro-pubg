
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    public class CrosshairForm : Form
    {
        private string crosshairType;
        private Color crosshairColor;

        public CrosshairForm(string type, Color color)
        {
            crosshairType = type;
            crosshairColor = color;

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            BackColor = Color.Magenta;
            TransparencyKey = Color.Magenta;
            TopMost = true;
            ShowInTaskbar = false;

            KeyPreview = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int centerX = ClientSize.Width / 2;
            int centerY = ClientSize.Height / 2;

            using (Pen pen = new Pen(crosshairColor, 2))
            {
                switch (crosshairType)
                {
                    case "Cross":
                        e.Graphics.DrawLine(pen, centerX - 20, centerY, centerX + 20, centerY);
                        e.Graphics.DrawLine(pen, centerX, centerY - 20, centerX, centerY + 20);
                        break;
                    case "Circle":
                        e.Graphics.DrawEllipse(pen, centerX - 20, centerY - 20, 40, 40);
                        break;
                    case "Dot":
                        using (SolidBrush brush = new SolidBrush(crosshairColor))
                        {
                            e.Graphics.FillEllipse(brush, centerX - 5, centerY - 5, 10, 10);
                        }
                        break;
                }
            }
        }
    }
}
