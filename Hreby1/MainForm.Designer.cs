
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddDish = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderDish = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveDish = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameDish = new System.Windows.Forms.ToolStripMenuItem();
            this.SortAZ = new System.Windows.Forms.ToolStripMenuItem();
            this.SortZA = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CuisineItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cuisineLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.ContextMenuStrip = this.ContextMenu;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 31);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(229, 382);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // ContextMenu
            // 
            this.ContextMenu.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDish,
            this.OrderDish,
            this.RemoveDish,
            this.RenameDish,
            this.SortAZ,
            this.SortZA});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(144, 136);
            this.ContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.СontexMenu_ItemClicked);
            // 
            // AddDish
            // 
            this.AddDish.Name = "AddDish";
            this.AddDish.Size = new System.Drawing.Size(143, 22);
            this.AddDish.Text = "AddDish";
            // 
            // OrderDish
            // 
            this.OrderDish.Enabled = false;
            this.OrderDish.Name = "OrderDish";
            this.OrderDish.Size = new System.Drawing.Size(143, 22);
            this.OrderDish.Text = "OrderDish";
            // 
            // RemoveDish
            // 
            this.RemoveDish.Enabled = false;
            this.RemoveDish.Name = "RemoveDish";
            this.RemoveDish.Size = new System.Drawing.Size(143, 22);
            this.RemoveDish.Text = "Remove Dish";
            // 
            // RenameDish
            // 
            this.RenameDish.Enabled = false;
            this.RenameDish.Name = "RenameDish";
            this.RenameDish.Size = new System.Drawing.Size(143, 22);
            this.RenameDish.Text = "Rename Dish";
            // 
            // SortAZ
            // 
            this.SortAZ.Name = "SortAZ";
            this.SortAZ.Size = new System.Drawing.Size(143, 22);
            this.SortAZ.Text = "Sort A-Z";
            // 
            // SortZA
            // 
            this.SortZA.Name = "SortZA";
            this.SortZA.Size = new System.Drawing.Size(143, 22);
            this.SortZA.Text = "Sort Z-A";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(559, 31);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(229, 382);
            this.checkedListBox2.TabIndex = 1;
            this.checkedListBox2.SelectedIndexChanged += new System.EventHandler(this.checkedListBox2_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(247, 106);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(306, 51);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "add ->";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.Location = new System.Drawing.Point(247, 184);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(306, 51);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "<- remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.orderButton.Location = new System.Drawing.Point(247, 264);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(306, 51);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileItem,
            this.CuisineItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileItem
            // 
            this.FileItem.Enabled = false;
            this.FileItem.Name = "FileItem";
            this.FileItem.Size = new System.Drawing.Size(37, 20);
            this.FileItem.Text = "File";
            // 
            // CuisineItem
            // 
            this.CuisineItem.Name = "CuisineItem";
            this.CuisineItem.Size = new System.Drawing.Size(58, 20);
            this.CuisineItem.Text = "Cuisine";
            this.CuisineItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CuisineItem_DropDownItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuisineLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 6;
            // 
            // cuisineLabel
            // 
            this.cuisineLabel.Name = "cuisineLabel";
            this.cuisineLabel.Size = new System.Drawing.Size(109, 17);
            this.cuisineLabel.Text = "No cuisine selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem AddDish;
        private System.Windows.Forms.ToolStripMenuItem OrderDish;
        private System.Windows.Forms.ToolStripMenuItem RemoveDish;
        private System.Windows.Forms.ToolStripMenuItem RenameDish;
        private ToolStripMenuItem SortAZ;
        private ToolStripMenuItem SortZA;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileItem;
        private ToolStripMenuItem CuisineItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel cuisineLabel;
    }
}

