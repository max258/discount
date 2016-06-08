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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sumCostWithDiscountTextBox = new System.Windows.Forms.TextBox();
            this.sumCostTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.discountsGroupBox = new System.Windows.Forms.GroupBox();
            this.goodsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.discountControl = new View.DiscountControl();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.discountsGroupBox.SuspendLayout();
            this.goodsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(848, 24);
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
            this.discountsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountsDataGridView.Location = new System.Drawing.Point(10, 23);
            this.discountsDataGridView.Margin = new System.Windows.Forms.Padding(30);
            this.discountsDataGridView.MultiSelect = false;
            this.discountsDataGridView.Name = "discountsDataGridView";
            this.discountsDataGridView.RowHeadersVisible = false;
            this.discountsDataGridView.Size = new System.Drawing.Size(220, 383);
            this.discountsDataGridView.TabIndex = 1;
            this.discountsDataGridView.SelectionChanged += new System.EventHandler(this.discountsDataGridView_SelectionChanged);
            // 
            // CreateRowButton
            // 
            this.CreateRowButton.Location = new System.Drawing.Point(10, 19);
            this.CreateRowButton.Name = "CreateRowButton";
            this.CreateRowButton.Size = new System.Drawing.Size(64, 23);
            this.CreateRowButton.TabIndex = 2;
            this.CreateRowButton.Text = "Create";
            this.CreateRowButton.UseVisualStyleBackColor = true;
            this.CreateRowButton.Click += new System.EventHandler(this.CreateRowButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(80, 19);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(64, 23);
            this.ModifyButton.TabIndex = 3;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(150, 19);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(64, 23);
            this.RemoveButton.TabIndex = 4;
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
            this.randomGoodButton.Location = new System.Drawing.Point(250, 19);
            this.randomGoodButton.Name = "randomGoodButton";
            this.randomGoodButton.Size = new System.Drawing.Size(98, 23);
            this.randomGoodButton.TabIndex = 6;
            this.randomGoodButton.Text = "Random good";
            this.randomGoodButton.UseVisualStyleBackColor = true;
            this.randomGoodButton.Click += new System.EventHandler(this.randomGoodButton_Click);
            // 
            // randomDiscountButton
            // 
            this.randomDiscountButton.Location = new System.Drawing.Point(10, 48);
            this.randomDiscountButton.Name = "randomDiscountButton";
            this.randomDiscountButton.Size = new System.Drawing.Size(98, 23);
            this.randomDiscountButton.TabIndex = 5;
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
            this.goodsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodsDataGridView.Location = new System.Drawing.Point(10, 23);
            this.goodsDataGridView.MultiSelect = false;
            this.goodsDataGridView.Name = "goodsDataGridView";
            this.goodsDataGridView.RowHeadersVisible = false;
            this.goodsDataGridView.Size = new System.Drawing.Size(270, 383);
            this.goodsDataGridView.TabIndex = 8;
            this.goodsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.goodsDataGridView_RowsAdded);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(354, 19);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(99, 23);
            this.applyButton.TabIndex = 7;
            this.applyButton.Text = "Apply discount";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Summary cost with discount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Summary cost";
            // 
            // sumCostWithDiscountTextBox
            // 
            this.sumCostWithDiscountTextBox.Location = new System.Drawing.Point(249, 103);
            this.sumCostWithDiscountTextBox.Name = "sumCostWithDiscountTextBox";
            this.sumCostWithDiscountTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumCostWithDiscountTextBox.TabIndex = 9;
            // 
            // sumCostTextBox
            // 
            this.sumCostTextBox.Location = new System.Drawing.Point(250, 64);
            this.sumCostTextBox.Name = "sumCostTextBox";
            this.sumCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.sumCostTextBox.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.randomDiscountButton);
            this.groupBox1.Controls.Add(this.RemoveButton);
            this.groupBox1.Controls.Add(this.CreateRowButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ModifyButton);
            this.groupBox1.Controls.Add(this.sumCostTextBox);
            this.groupBox1.Controls.Add(this.applyButton);
            this.groupBox1.Controls.Add(this.randomGoodButton);
            this.groupBox1.Controls.Add(this.sumCostWithDiscountTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 440);
            this.groupBox1.MaximumSize = new System.Drawing.Size(530, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // discountsGroupBox
            // 
            this.discountsGroupBox.Controls.Add(this.discountsDataGridView);
            this.discountsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.discountsGroupBox.Location = new System.Drawing.Point(0, 24);
            this.discountsGroupBox.Name = "discountsGroupBox";
            this.discountsGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.discountsGroupBox.Size = new System.Drawing.Size(240, 416);
            this.discountsGroupBox.TabIndex = 13;
            this.discountsGroupBox.TabStop = false;
            this.discountsGroupBox.Text = "Discounts";
            // 
            // goodsGroupBox
            // 
            this.goodsGroupBox.Controls.Add(this.goodsDataGridView);
            this.goodsGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.goodsGroupBox.Location = new System.Drawing.Point(240, 24);
            this.goodsGroupBox.Name = "goodsGroupBox";
            this.goodsGroupBox.Padding = new System.Windows.Forms.Padding(10);
            this.goodsGroupBox.Size = new System.Drawing.Size(290, 416);
            this.goodsGroupBox.TabIndex = 14;
            this.goodsGroupBox.TabStop = false;
            this.goodsGroupBox.Text = "Goods";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.discountControl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(530, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 416);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // discountControl
            // 
            this.discountControl.Discount = null;
            this.discountControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountControl.Location = new System.Drawing.Point(3, 16);
            this.discountControl.Name = "discountControl";
            this.discountControl.Size = new System.Drawing.Size(312, 397);
            this.discountControl.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.goodsGroupBox);
            this.Controls.Add(this.discountsGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(864, 520);
            this.Name = "MainForm";
            this.Text = "Discount System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.discountsGroupBox.ResumeLayout(false);
            this.goodsGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox sumCostWithDiscountTextBox;
        private System.Windows.Forms.TextBox sumCostTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DiscountControl discountControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox discountsGroupBox;
        private System.Windows.Forms.GroupBox goodsGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

