using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hreby1
{
    public partial class Document : Form
    {
        GeneralForm editor;

        public Bitmap drawingArea;
        Graphics graphics;

        public Document(GeneralForm editor, Bitmap bitmap)
        {
            this.editor = editor;
            MdiParent = editor;

            drawingArea = bitmap;
            InitializeComponent();
            graphics = Graphics.FromImage(drawingArea);
            pictureBox.Image = drawingArea;
        }

        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            switch (editor.currentTool)
            {
                case Tool.CenterLine:
                    graphics.DrawLine(editor.pen, e.X, e.Y, pictureBox.Width / 2, pictureBox.Height / 2);
                    break;
                case Tool.Squares:
                    graphics.DrawRectangle(editor.pen, new Rectangle(e.X + 5, e.Y + 5, 10, 10));
                    break;

            }
            pictureBox.Image = drawingArea;
        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                graphics.Clear(Color.Transparent);
                pictureBox.Image = drawingArea;
            }
        }
    }
}
