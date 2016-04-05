namespace View
{
    partial class CreateForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.percentRadioButton = new System.Windows.Forms.RadioButton();
            this.certificateRadioButton = new System.Windows.Forms.RadioButton();
            this.percentDiscountGroupBox = new System.Windows.Forms.GroupBox();
            this.percentDiscountCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.percentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.certificateDiscountGroupBox = new System.Windows.Forms.GroupBox();
            this.certificateDiscountCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.percentDiscountGroupBox.SuspendLayout();
            this.certificateDiscountGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(45, 224);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(131, 224);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // percentRadioButton
            // 
            this.percentRadioButton.AutoSize = true;
            this.percentRadioButton.Location = new System.Drawing.Point(12, 18);
            this.percentRadioButton.Name = "percentRadioButton";
            this.percentRadioButton.Size = new System.Drawing.Size(107, 17);
            this.percentRadioButton.TabIndex = 2;
            this.percentRadioButton.Text = "Percent Discount";
            this.percentRadioButton.UseVisualStyleBackColor = true;
            this.percentRadioButton.CheckedChanged += new System.EventHandler(this.percentRadioButton_CheckedChanged);
            // 
            // certificateRadioButton
            // 
            this.certificateRadioButton.AutoSize = true;
            this.certificateRadioButton.Location = new System.Drawing.Point(12, 41);
            this.certificateRadioButton.Name = "certificateRadioButton";
            this.certificateRadioButton.Size = new System.Drawing.Size(117, 17);
            this.certificateRadioButton.TabIndex = 3;
            this.certificateRadioButton.Text = "Certificate Discount";
            this.certificateRadioButton.UseVisualStyleBackColor = true;
            this.certificateRadioButton.CheckedChanged += new System.EventHandler(this.certificateRadioButton_CheckedChanged);
            // 
            // percentDiscountGroupBox
            // 
            this.percentDiscountGroupBox.Controls.Add(this.percentDiscountCategoryComboBox);
            this.percentDiscountGroupBox.Controls.Add(this.percentTextBox);
            this.percentDiscountGroupBox.Controls.Add(this.label5);
            this.percentDiscountGroupBox.Controls.Add(this.label4);
            this.percentDiscountGroupBox.Location = new System.Drawing.Point(14, 100);
            this.percentDiscountGroupBox.Name = "percentDiscountGroupBox";
            this.percentDiscountGroupBox.Size = new System.Drawing.Size(234, 100);
            this.percentDiscountGroupBox.TabIndex = 14;
            this.percentDiscountGroupBox.TabStop = false;
            this.percentDiscountGroupBox.Text = "Percent Discount";
            this.percentDiscountGroupBox.Visible = false;
            // 
            // percentDiscountCategoryComboBox
            // 
            this.percentDiscountCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.percentDiscountCategoryComboBox.FormattingEnabled = true;
            this.percentDiscountCategoryComboBox.Location = new System.Drawing.Point(94, 57);
            this.percentDiscountCategoryComboBox.Name = "percentDiscountCategoryComboBox";
            this.percentDiscountCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.percentDiscountCategoryComboBox.TabIndex = 5;
            // 
            // percentTextBox
            // 
            this.percentTextBox.Location = new System.Drawing.Point(94, 24);
            this.percentTextBox.Name = "percentTextBox";
            this.percentTextBox.Size = new System.Drawing.Size(42, 20);
            this.percentTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Percent";
            // 
            // certificateDiscountGroupBox
            // 
            this.certificateDiscountGroupBox.Controls.Add(this.certificateDiscountCategoryComboBox);
            this.certificateDiscountGroupBox.Controls.Add(this.sumTextBox);
            this.certificateDiscountGroupBox.Controls.Add(this.label7);
            this.certificateDiscountGroupBox.Controls.Add(this.label6);
            this.certificateDiscountGroupBox.Location = new System.Drawing.Point(14, 100);
            this.certificateDiscountGroupBox.Name = "certificateDiscountGroupBox";
            this.certificateDiscountGroupBox.Size = new System.Drawing.Size(234, 100);
            this.certificateDiscountGroupBox.TabIndex = 14;
            this.certificateDiscountGroupBox.TabStop = false;
            this.certificateDiscountGroupBox.Text = "Certificate Discount";
            this.certificateDiscountGroupBox.Visible = false;
            // 
            // certificateDiscountCategoryComboBox
            // 
            this.certificateDiscountCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.certificateDiscountCategoryComboBox.FormattingEnabled = true;
            this.certificateDiscountCategoryComboBox.Location = new System.Drawing.Point(94, 57);
            this.certificateDiscountCategoryComboBox.Name = "certificateDiscountCategoryComboBox";
            this.certificateDiscountCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.certificateDiscountCategoryComboBox.TabIndex = 3;
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(94, 24);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(81, 20);
            this.sumTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sum";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 275);
            this.Controls.Add(this.percentDiscountGroupBox);
            this.Controls.Add(this.certificateDiscountGroupBox);
            this.Controls.Add(this.certificateRadioButton);
            this.Controls.Add(this.percentRadioButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "CreateForm";
            this.Text = "New discount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateRowForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateRowForm_Load);
            this.percentDiscountGroupBox.ResumeLayout(false);
            this.percentDiscountGroupBox.PerformLayout();
            this.certificateDiscountGroupBox.ResumeLayout(false);
            this.certificateDiscountGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.RadioButton percentRadioButton;
        private System.Windows.Forms.RadioButton certificateRadioButton;
        private System.Windows.Forms.GroupBox percentDiscountGroupBox;
        private System.Windows.Forms.ComboBox percentDiscountCategoryComboBox;
        private System.Windows.Forms.TextBox percentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox certificateDiscountGroupBox;
        private System.Windows.Forms.ComboBox certificateDiscountCategoryComboBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}