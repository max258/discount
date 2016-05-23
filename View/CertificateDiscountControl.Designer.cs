namespace View
{
    partial class CertificateDiscountControl
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
            this.certificateDiscountCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // certificateDiscountCategoryComboBox
            // 
            this.certificateDiscountCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.certificateDiscountCategoryComboBox.FormattingEnabled = true;
            this.certificateDiscountCategoryComboBox.Location = new System.Drawing.Point(86, 44);
            this.certificateDiscountCategoryComboBox.Name = "certificateDiscountCategoryComboBox";
            this.certificateDiscountCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.certificateDiscountCategoryComboBox.TabIndex = 3;
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(86, 11);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(81, 20);
            this.sumTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sum";
            // 
            // CertificateDiscountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.certificateDiscountCategoryComboBox);
            this.Controls.Add(this.sumTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "CertificateDiscountControl";
            this.Size = new System.Drawing.Size(223, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox certificateDiscountCategoryComboBox;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
