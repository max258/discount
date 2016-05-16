namespace View
{
    partial class PercentDiscountControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.percentDiscountCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.percentTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // percentDiscountCategoryComboBox
            // 
            this.percentDiscountCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.percentDiscountCategoryComboBox.FormattingEnabled = true;
            this.percentDiscountCategoryComboBox.Location = new System.Drawing.Point(86, 44);
            this.percentDiscountCategoryComboBox.Name = "percentDiscountCategoryComboBox";
            this.percentDiscountCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.percentDiscountCategoryComboBox.TabIndex = 5;
            // 
            // percentTextBox
            // 
            this.percentTextBox.Location = new System.Drawing.Point(86, 11);
            this.percentTextBox.Name = "percentTextBox";
            this.percentTextBox.Size = new System.Drawing.Size(42, 20);
            this.percentTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Percent";
            // 
            // PercentDiscountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.percentDiscountCategoryComboBox);
            this.Controls.Add(this.percentTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "PercentDiscountControl";
            this.Size = new System.Drawing.Size(223, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox percentDiscountCategoryComboBox;
        private System.Windows.Forms.TextBox percentTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
