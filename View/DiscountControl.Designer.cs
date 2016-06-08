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
            this.percentDiscountControl = new View.PercentDiscountControl();
            this.certificateDiscountControl = new View.CertificateDiscountControl();
            this.SuspendLayout();
            // 
            // certificateRadioButton
            // 
            this.certificateRadioButton.AutoSize = true;
            this.certificateRadioButton.Location = new System.Drawing.Point(4, 26);
            this.certificateRadioButton.Name = "certificateRadioButton";
            this.certificateRadioButton.Size = new System.Drawing.Size(117, 17);
            this.certificateRadioButton.TabIndex = 2;
            this.certificateRadioButton.Text = "Certificate Discount";
            this.certificateRadioButton.UseVisualStyleBackColor = true;
            this.certificateRadioButton.CheckedChanged += new System.EventHandler(this.certificateRadioButton_CheckedChanged);
            // 
            // percentRadioButton
            // 
            this.percentRadioButton.AutoSize = true;
            this.percentRadioButton.Location = new System.Drawing.Point(4, 3);
            this.percentRadioButton.Name = "percentRadioButton";
            this.percentRadioButton.Size = new System.Drawing.Size(107, 17);
            this.percentRadioButton.TabIndex = 1;
            this.percentRadioButton.Text = "Percent Discount";
            this.percentRadioButton.UseVisualStyleBackColor = true;
            this.percentRadioButton.CheckedChanged += new System.EventHandler(this.percentRadioButton_CheckedChanged);
            // 
            // percentDiscountControl
            // 
            this.percentDiscountControl.Location = new System.Drawing.Point(0, 58);
            this.percentDiscountControl.Name = "percentDiscountControl";
            this.percentDiscountControl.Size = new System.Drawing.Size(200, 50);
            this.percentDiscountControl.TabIndex = 19;
            this.percentDiscountControl.Visible = false;
            // 
            // certificateDiscountControl
            // 
            this.certificateDiscountControl.Location = new System.Drawing.Point(0, 58);
            this.certificateDiscountControl.Name = "certificateDiscountControl";
            this.certificateDiscountControl.Size = new System.Drawing.Size(200, 50);
            this.certificateDiscountControl.TabIndex = 20;
            this.certificateDiscountControl.Visible = false;
            // 
            // DiscountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.percentDiscountControl);
            this.Controls.Add(this.certificateDiscountControl);
            this.Controls.Add(this.certificateRadioButton);
            this.Controls.Add(this.percentRadioButton);
            this.Name = "DiscountControl";
            this.Size = new System.Drawing.Size(202, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton certificateRadioButton;
        private System.Windows.Forms.RadioButton percentRadioButton;
        private PercentDiscountControl percentDiscountControl;
        private CertificateDiscountControl certificateDiscountControl;
    }
}
