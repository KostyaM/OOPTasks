
namespace Hreby1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ToolStripMenuItem Black;
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.fromCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.squares = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarColor = new System.Windows.Forms.ToolStripMenuItem();
            this.Red = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            Black = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.picCanvas.Location = new System.Drawing.Point(-1, 26);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(803, 425);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tools,
            this.ToolbarColor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tools
            // 
            this.Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromCenter,
            this.squares});
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(46, 20);
            this.Tools.Text = "Tools";
            // 
            // fromCenter
            // 
            this.fromCenter.Name = "fromCenter";
            this.fromCenter.Size = new System.Drawing.Size(161, 22);
            this.fromCenter.Text = "Line from center";
            this.fromCenter.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.fromCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.fromCenter.Click += new System.EventHandler(this.menuStrip1_FromCenterClicked);
            // 
            // squares
            // 
            this.squares.Name = "squares";
            this.squares.Size = new System.Drawing.Size(161, 22);
            this.squares.Text = "Squares";
            this.squares.Click += new System.EventHandler(this.menuStrip1_SquaresClicked);
            // 
            // ToolbarColor
            // 
            this.ToolbarColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            Black,
            this.Red});
            this.ToolbarColor.Name = "ToolbarColor";
            this.ToolbarColor.Size = new System.Drawing.Size(48, 20);
            this.ToolbarColor.Text = "Color";
            this.ToolbarColor.Click += new System.EventHandler(this.menuStrip1_ColorClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tools;
        private System.Windows.Forms.ToolStripMenuItem ToolbarColor;
        private System.Windows.Forms.ToolStripMenuItem fromCenter;
        private System.Windows.Forms.ToolStripMenuItem squares;
        private System.Windows.Forms.ToolStripMenuItem Red;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}

