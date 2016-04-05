namespace View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discountsDataGridView = new System.Windows.Forms.DataGridView();
            this.CreateRowButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.randomGoodButton = new System.Windows.Forms.Button();
            this.randomDiscountButton = new System.Windows.Forms.Button();
            this.goodsDataGridView = new System.Windows.Forms.DataGridView();
            this.applyButton = new System.Windows.Forms.Button();
            this.discountsGroupBox = new System.Windows.Forms.GroupBox();
            this.goodsGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).BeginInit();
            this.discountsGroupBox.SuspendLayout();
            this.goodsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(563, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // discountsDataGridView
            // 
            this.discountsDataGridView.AllowUserToAddRows = false;
            this.discountsDataGridView.AllowUserToDeleteRows = false;
            this.discountsDataGridView.AllowUserToResizeColumns = false;
            this.discountsDataGridView.AllowUserToResizeRows = false;
            this.discountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.discountsDataGridView.Location = new System.Drawing.Point(9, 25);
            this.discountsDataGridView.Name = "discountsDataGridView";
            this.discountsDataGridView.RowHeadersVisible = false;
            this.discountsDataGridView.Size = new System.Drawing.Size(220, 311);
            this.discountsDataGridView.TabIndex = 2;
            // 
            // CreateRowButton
            // 
            this.CreateRowButton.Location = new System.Drawing.Point(9, 347);
            this.CreateRowButton.Name = "CreateRowButton";
            this.CreateRowButton.Size = new System.Drawing.Size(64, 23);
            this.CreateRowButton.TabIndex = 3;
            this.CreateRowButton.Text = "Create";
            this.CreateRowButton.UseVisualStyleBackColor = true;
            this.CreateRowButton.Click += new System.EventHandler(this.CreateRowButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(87, 347);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(64, 23);
            this.ModifyButton.TabIndex = 4;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(165, 347);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(64, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // randomGoodButton
            // 
            this.randomGoodButton.Location = new System.Drawing.Point(36, 348);
            this.randomGoodButton.Name = "randomGoodButton";
            this.randomGoodButton.Size = new System.Drawing.Size(98, 23);
            this.randomGoodButton.TabIndex = 6;
            this.randomGoodButton.Text = "Random good";
            this.randomGoodButton.UseVisualStyleBackColor = true;
            this.randomGoodButton.Click += new System.EventHandler(this.randomGoodButton_Click);
            // 
            // randomDiscountButton
            // 
            this.randomDiscountButton.Location = new System.Drawing.Point(74, 377);
            this.randomDiscountButton.Name = "randomDiscountButton";
            this.randomDiscountButton.Size = new System.Drawing.Size(98, 23);
            this.randomDiscountButton.TabIndex = 7;
            this.randomDiscountButton.Text = "Random discount";
            this.randomDiscountButton.UseVisualStyleBackColor = true;
            this.randomDiscountButton.Click += new System.EventHandler(this.randomDiscountButton_Click);
            // 
            // goodsDataGridView
            // 
            this.goodsDataGridView.AllowUserToAddRows = false;
            this.goodsDataGridView.AllowUserToDeleteRows = false;
            this.goodsDataGridView.AllowUserToResizeColumns = false;
            this.goodsDataGridView.AllowUserToResizeRows = false;
            this.goodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDataGridView.Location = new System.Drawing.Point(6, 25);
            this.goodsDataGridView.Name = "goodsDataGridView";
            this.goodsDataGridView.RowHeadersVisible = false;
            this.goodsDataGridView.Size = new System.Drawing.Size(270, 311);
            this.goodsDataGridView.TabIndex = 8;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(144, 348);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(99, 23);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "Apply discount";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // discountsGroupBox
            // 
            this.discountsGroupBox.Controls.Add(this.discountsDataGridView);
            this.discountsGroupBox.Controls.Add(this.CreateRowButton);
            this.discountsGroupBox.Controls.Add(this.ModifyButton);
            this.discountsGroupBox.Controls.Add(this.RemoveButton);
            this.discountsGroupBox.Controls.Add(this.randomDiscountButton);
            this.discountsGroupBox.Location = new System.Drawing.Point(12, 27);
            this.discountsGroupBox.Name = "discountsGroupBox";
            this.discountsGroupBox.Size = new System.Drawing.Size(238, 406);
            this.discountsGroupBox.TabIndex = 10;
            this.discountsGroupBox.TabStop = false;
            this.discountsGroupBox.Text = "Discounts";
            // 
            // goodsGroupBox
            // 
            this.goodsGroupBox.Controls.Add(this.goodsDataGridView);
            this.goodsGroupBox.Controls.Add(this.randomGoodButton);
            this.goodsGroupBox.Controls.Add(this.applyButton);
            this.goodsGroupBox.Location = new System.Drawing.Point(275, 27);
            this.goodsGroupBox.Name = "goodsGroupBox";
            this.goodsGroupBox.Size = new System.Drawing.Size(283, 406);
            this.goodsGroupBox.TabIndex = 0;
            this.goodsGroupBox.TabStop = false;
            this.goodsGroupBox.Text = "Goods";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(563, 445);
            this.Controls.Add(this.goodsGroupBox);
            this.Controls.Add(this.discountsGroupBox);
            this.Controls.Add(this.menuStrip2);
            this.Name = "MainForm";
            this.Text = "Discount System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).EndInit();
            this.discountsGroupBox.ResumeLayout(false);
            this.goodsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.DataGridView discountsDataGridView;
        private System.Windows.Forms.Button CreateRowButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button randomDiscountButton;
        private System.Windows.Forms.Button randomGoodButton;
        private System.Windows.Forms.DataGridView goodsDataGridView;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.GroupBox goodsGroupBox;
        private System.Windows.Forms.GroupBox discountsGroupBox;
    }
}

