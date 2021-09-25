
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
            this.resultBox = new System.Windows.Forms.PictureBox();
            this.redScroll = new System.Windows.Forms.HScrollBar();
            this.greenScroll = new System.Windows.Forms.HScrollBar();
            this.blueScroll = new System.Windows.Forms.HScrollBar();
            this.lockCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 12);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(762, 258);
            this.resultBox.TabIndex = 0;
            this.resultBox.TabStop = false;
            this.resultBox.Click += new System.EventHandler(this.resultBox_Click);
            // 
            // redScroll
            // 
            this.redScroll.Location = new System.Drawing.Point(165, 304);
            this.redScroll.Name = "redScroll";
            this.redScroll.Size = new System.Drawing.Size(461, 32);
            this.redScroll.TabIndex = 1;
            this.redScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redScroll_Scroll);
            // 
            // greenScroll
            // 
            this.greenScroll.Location = new System.Drawing.Point(165, 360);
            this.greenScroll.Name = "greenScroll";
            this.greenScroll.Size = new System.Drawing.Size(461, 32);
            this.greenScroll.TabIndex = 2;
            this.greenScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenScroll_Scroll);
            // 
            // blueScroll
            // 
            this.blueScroll.Location = new System.Drawing.Point(165, 409);
            this.blueScroll.Name = "blueScroll";
            this.blueScroll.Size = new System.Drawing.Size(461, 32);
            this.blueScroll.TabIndex = 3;
            this.blueScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueScroll_Scroll);
            // 
            // lockCheck
            // 
            this.lockCheck.AutoSize = true;
            this.lockCheck.Location = new System.Drawing.Point(706, 378);
            this.lockCheck.Name = "lockCheck";
            this.lockCheck.Size = new System.Drawing.Size(15, 14);
            this.lockCheck.TabIndex = 4;
            this.lockCheck.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lockCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.lockCheck.UseVisualStyleBackColor = true;
            this.lockCheck.UseWaitCursor = true;
            this.lockCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(679, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(58, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "R";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(58, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(58, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lockCheck);
            this.Controls.Add(this.blueScroll);
            this.Controls.Add(this.greenScroll);
            this.Controls.Add(this.redScroll);
            this.Controls.Add(this.resultBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox resultBox;
        private System.Windows.Forms.Control scrollBar;
        private System.Windows.Forms.HScrollBar redScroll;
        private System.Windows.Forms.HScrollBar greenScroll;
        private System.Windows.Forms.HScrollBar blueScroll;
        private System.Windows.Forms.CheckBox lockCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

