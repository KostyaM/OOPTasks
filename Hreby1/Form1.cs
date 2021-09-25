using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hreby1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            redScroll.Maximum = 255;
            greenScroll.Maximum = 255;
            blueScroll.Maximum = 255;
            updateColor();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var scrollPosition = redScroll.Value;
            if (lockCheck.Checked) {
                greenScroll.Value = scrollPosition;
                blueScroll.Value = scrollPosition;
            }
            updateColor();
        }

        private void label2_Click(object sender, EventArgs e){ }

        private void redScroll_Scroll(object sender, ScrollEventArgs e)
        {

            if (lockCheck.Checked) {
                var scrollPosition = redScroll.Value;
                greenScroll.Value = scrollPosition;
                blueScroll.Value = scrollPosition;
            }
            updateColor();
        }

        private void greenScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (lockCheck.Checked) {
                var scrollPosition = greenScroll.Value;
                redScroll.Value = scrollPosition;
                blueScroll.Value = scrollPosition;
            }
            updateColor();
        }

        private void blueScroll_Scroll(object sender, ScrollEventArgs e)
        {
            if (lockCheck.Checked)
            {
                var scrollPosition = blueScroll.Value;
                greenScroll.Value = scrollPosition;
                redScroll.Value = scrollPosition;
            }
            updateColor();
        }

        private void updateColor() {
            resultBox.BackColor = Color.FromArgb(255, redScroll.Value, greenScroll.Value, blueScroll.Value);
        }

        private void resultBox_Click(object sender, EventArgs e)
        {

        }
    }
}
