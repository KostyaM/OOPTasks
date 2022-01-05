
namespace Hreby1
{
    partial class GeneralForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.fromCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.squares = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolbarColor = new System.Windows.Forms.ToolStripMenuItem();
            this.Red = new System.Windows.Forms.ToolStripMenuItem();
            this.windowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            Black = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Black
            // 
            Black.Name = "Black";
            Black.Size = new System.Drawing.Size(67, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItem,
            this.Tools,
            this.ToolbarColor,
            this.windowItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileItem
            // 
            this.FileItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newItem,
            this.openItem,
            this.saveAs});
            this.FileItem.Name = "FileItem";
            this.FileItem.Size = new System.Drawing.Size(37, 20);
            this.FileItem.Text = "File";
            // 
            // newItem
            // 
            this.newItem.Name = "newItem";
            this.newItem.Size = new System.Drawing.Size(114, 22);
            this.newItem.Text = "New";
            this.newItem.Click += new System.EventHandler(this.newFileClick);
            // 
            // openItem
            // 
            this.openItem.Name = "openItem";
            this.openItem.Size = new System.Drawing.Size(114, 22);
            this.openItem.Text = "Open";
            this.openItem.Click += new System.EventHandler(this.openFileClick);
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
            // Red
            // 
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(67, 22);
            // 
            // windowItem
            // 
            this.windowItem.Name = "windowItem";
            this.windowItem.Size = new System.Drawing.Size(63, 20);
            this.windowItem.Text = "Window";
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.Size = new System.Drawing.Size(114, 22);
            this.saveAs.Text = "Save As";
            this.saveAs.Click += new System.EventHandler(this.saveFileClick);
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GeneralForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem FileItem;
        private System.Windows.Forms.ToolStripMenuItem windowItem;
        private System.Windows.Forms.ToolStripMenuItem newItem;
        private System.Windows.Forms.ToolStripMenuItem openItem;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
    }
}

