using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hreby1
{

    enum Tool{
        CenterLine,
        Squares
    }
    public partial class Form1 : Form
    {
        Bitmap drawingArea;
        Pen pen;
        Graphics graphics;

        Tool currentTool = Tool.CenterLine;
        Color currentColor = Color.Black;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 1);
            drawingArea = new Bitmap(picCanvas.Width, picCanvas.Height);
            graphics = Graphics.FromImage(drawingArea);

        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            switch (currentTool) 
            {
                case Tool.CenterLine:
                    graphics.DrawLine(pen, e.X, e.Y, picCanvas.Width / 2, picCanvas.Height / 2);
                    break;
                case Tool.Squares:
                    graphics.DrawRectangle(pen, new Rectangle(e.X + 5, e.Y + 5, 10, 10));
                    break;

            }
            picCanvas.Image = drawingArea;
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                graphics.Clear(Color.Transparent);
                picCanvas.Image = drawingArea;
            }
        }

        private void menuStrip1_FromCenterClicked(object? sender, EventArgs e)
        {
            currentTool = Tool.CenterLine;
        }

        private void menuStrip1_SquaresClicked(object? sender, EventArgs e)
        {
            currentTool = Tool.Squares;
        }

        private void menuStrip1_ColorClicked(object? sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            colorDialog.Color = currentColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
                currentColor = colorDialog.Color;
            pen = new Pen(currentColor, 1);
        }

    }

}
