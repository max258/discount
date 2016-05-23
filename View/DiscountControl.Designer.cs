namespace View
{
    partial class DiscountControl
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
            this.certificateRadioButton = new System.Windows.Forms.RadioButton();
            this.percentRadioButton = new System.Windows.Forms.RadioButton();
            this.percentDiscountControl1 = new View.PercentDiscountControl();
            this.certificateDiscountControl1 = new View.CertificateDiscountControl();
            this.SuspendLayout();
            // 
            // certificateRadioButton
            // 
            this.certificateRadioButton.AutoSize = true;
            this.certificateRadioButton.Location = new System.Drawing.Point(14, 35);
            this.certificateRadioButton.Name = "certificateRadioButton";
            this.certificateRadioButton.Size = new System.Drawing.Size(117, 17);
            this.certificateRadioButton.TabIndex = 16;
            this.certificateRadioButton.Text = "Certificate Discount";
            this.certificateRadioButton.UseVisualStyleBackColor = true;
            this.certificateRadioButton.CheckedChanged += new System.EventHandler(this.certificateRadioButton_CheckedChanged);
            // 
            // percentRadioButton
            // 
            this.percentRadioButton.AutoSize = true;
            this.percentRadioButton.Location = new System.Drawing.Point(14, 12);
            this.percentRadioButton.Name = "percentRadioButton";
            this.percentRadioButton.Size = new System.Drawing.Size(107, 17);
            this.percentRadioButton.TabIndex = 15;
            this.percentRadioButton.Text = "Percent Discount";
            this.percentRadioButton.UseVisualStyleBackColor = true;
            this.percentRadioButton.CheckedChanged += new System.EventHandler(this.percentRadioButton_CheckedChanged);
            // 
            // percentDiscountControl1
            // 
            this.percentDiscountControl1.Location = new System.Drawing.Point(14, 73);
            this.percentDiscountControl1.Name = "percentDiscountControl1";
            this.percentDiscountControl1.Size = new System.Drawing.Size(223, 81);
            this.percentDiscountControl1.TabIndex = 19;
            this.percentDiscountControl1.Visible = false;
            // 
            // certificateDiscountControl1
            // 
            this.certificateDiscountControl1.Location = new System.Drawing.Point(14, 73);
            this.certificateDiscountControl1.Name = "certificateDiscountControl1";
            this.certificateDiscountControl1.Size = new System.Drawing.Size(223, 82);
            this.certificateDiscountControl1.TabIndex = 20;
            this.certificateDiscountControl1.Visible = false;
            // 
            // DiscountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.percentDiscountControl1);
            this.Controls.Add(this.certificateDiscountControl1);
            this.Controls.Add(this.certificateRadioButton);
            this.Controls.Add(this.percentRadioButton);
            this.Name = "DiscountControl";
            this.Size = new System.Drawing.Size(259, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton certificateRadioButton;
        private System.Windows.Forms.RadioButton percentRadioButton;
        private PercentDiscountControl percentDiscountControl1;
        private CertificateDiscountControl certificateDiscountControl1;
    }
}
