using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hreby1
{

    public enum Tool{
        CenterLine,
        Squares
    }
    public partial class GeneralForm : Form
    {
 
        public Pen pen;
        public Tool currentTool = Tool.CenterLine;
        public Color currentColor = Color.Black;
        public GeneralForm()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 1);
            IsMdiContainer = true;
        }

        private void newFileClick(object? sender, EventArgs e)
        {
           new Document(this, new Bitmap(1920, 1080)).Show();
        }

        private void openFileClick(object? sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            Image pic = Image.FromFile(openFileDialog1.FileName);
            float k = 1;
            if (pic.Width >= pic.Height && pic.Width > 1920) k = 1920f / pic.Width;
            else if (pic.Width < pic.Height && pic.Height > 1080) k = 1080 / pic.Height;
            new Document(this, new Bitmap(pic, (int)(pic.Width * k), (int)(pic.Height * k))).Show();
        }

        private void saveFileClick(object? sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            Document drawing = (Document)ActiveMdiChild;
            drawing.drawingArea.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
            ActiveMdiChild.Text = saveFileDialog1.FileName;
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
